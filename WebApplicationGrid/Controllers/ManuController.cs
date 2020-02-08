using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using WebApplicationGrid.Models;
using WebApplicationGrid.ViewModels;
using WebApplicationGrid.ViewModels.HelperModels;

namespace WebApplicationGrid.Controllers
{
    public class ManuController : Controller
    {
        public string GetSubString(string source, string start, string end)
        {
            string[] separatorId = new[] { start };
            string[] separatorIdHelper = new[] { end };
            var preRes = source.Split(separatorId, StringSplitOptions.None);
            return source.Split(separatorId, StringSplitOptions.None)[1].Split(separatorIdHelper, StringSplitOptions.None)[0];
        }

        public List<DropDownModel> CreateDropdownHierarchy(List<ManuVModel> source)
        {
           List<DropDownModel> res = new List<DropDownModel>();
           List<ManuVModel> flDorpDown = new List<ManuVModel>();
           List<List<ManuVModel>> slDropDown = new List<List<ManuVModel>>();
           Dictionary<int, List<ManuVModel>> tlDropDown = new Dictionary<int, List<ManuVModel>>();
           
           for(int i=0;i<source.Count; i++)
            {
                for(int j=0; j<source.Count;j++)
                {
                    
                    if(source[i].Id == source[j].ParentId && i!=j)
                        source[i].HasChild=true;
                }
            }

           for (int i=0;i<source.Count;i++)
            {
                if (source[i].ParentId == 0 && source[i].Id != 0)
                {
                    flDorpDown.Add(source[i]);
                }
                    
            }
           foreach (var item in flDorpDown)
            {
                slDropDown.Add(source.Where(d => d.ParentId == item.Id).ToList());
            }

           foreach (var flItem in slDropDown)
            {
                foreach (var slItem in flItem)
                {
                    Dictionary<int, List<ManuVModel>> restmp = new Dictionary<int, List<ManuVModel>>();
                    var tmp = source.Where(c => c.ParentId == slItem.Id).ToList();
                    if(tmp.Count>0)
                    {
                        //restmp.Add(slItem.Id, tmp);
                        tlDropDown.Add(slItem.Id, tmp);
                    }
                   
                }
            }


           foreach (var item in flDorpDown)
            {
                var seconlevelIds = source.Where(c => c.ParentId == item.Id).Select(p => p.Id).ToList();
                Dictionary<int, List<ManuVModel>> tlDropDownes = new Dictionary<int, List<ManuVModel>>();

                foreach (var itemid in seconlevelIds)
                {
                    if(source.Where(c=>c.Id==itemid).First().HasChild )
                    {
                        tlDropDownes.Add(itemid, tlDropDown[itemid]);
                        
                    }
                    
                }
                var fsdf = tlDropDownes.Count();
                //List<Dictionary<int, List<ManuVModel>>> tlDropDownres = new List<Dictionary<int, List<ManuVModel>>>();
                //foreach (var element in finres)
                //{
                //    tlDropDownres.Add(new Dictionary<int, List<ManuVModel>> { element.Key });
                //}
                res.Add(new DropDownModel
                {
                    FirstLevel = item,
                    SecondLevel = source.Where(c => c.ParentId == item.Id).ToList(),
                    ThirdLevel = new Dictionary<int, Dictionary<int, List<ManuVModel>>> { { item.Id, tlDropDownes } }
                });
            }
            return res;
        }
        
        // GET: Manu
        public ActionResult Index()
        {
            System.Data.Entity.Core.Objects.ObjectParameter xmlOut = new System.Data.Entity.Core.Objects.ObjectParameter("xmlOut", typeof(object));
            var userId = int.Parse(Session["userId"].ToString());

            using (var _context = new Entities())
            {

               var res = _context.WebShellOperation(userId,xmlOut);
            }
            var xmlDoc = xmlOut.Value;
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlDoc.ToString());

            List<ManuVModel> ManuOpList = new List<ManuVModel>();
            var shellOperations = doc.GetElementsByTagName("ShellOperation");
            var shellOperationsGroup = doc.GetElementsByTagName("ShellOperationGroup"); 

            for (int i = 0; i < shellOperations.Count; i++)
            {
                string id = GetSubString(shellOperations[i].InnerXml, "<ShellOperationID>", "</");
                string key = GetSubString(shellOperations[i].InnerXml, "<ShellOperationKey>", "</");
                string name = GetSubString(shellOperations[i].InnerXml, "<ShellOperationName>", "</");
                string groupId = GetSubString(shellOperations[i].InnerXml, "<ShellOperationGroupID>", "</");

                ManuOpList.Add(new ManuVModel
                {
                    Id = int.Parse(id),
                    Key = key,
                    Name = name,
                    ParentId = int.Parse(groupId)
                });
            }
            for (int i=0;i<shellOperationsGroup.Count;i++)
            {
                string id = GetSubString(shellOperationsGroup[i].InnerXml, "<ShellOperationGroupID>", "</");
                string key = GetSubString(shellOperationsGroup[i].InnerXml, "<ShellOperationGroupKey>", "</");
                string name = GetSubString(shellOperationsGroup[i].InnerXml, "<ShellOperationGroupName>", "</");
                string groupId = GetSubString(shellOperationsGroup[i].InnerXml, "<ShellOperationGroupParentID>", "</");

                ManuOpList.Add(new ManuVModel
                {
                    Id = int.Parse(id),
                    Key = key,
                    Name = name,
                    ParentId = int.Parse(groupId),
                });
            }
            var modelForView = CreateDropdownHierarchy(ManuOpList);
            return View(modelForView);
        }
    }
}