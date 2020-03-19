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

            for (int i = 0; i < source.Count; i++)
            {
                for (int j = 0; j < source.Count; j++)
                {

                    if (source[i].Id == source[j].ParentId && i != j)
                        source[i].HasChild = true;
                }
            }

            for (int i = 0; i < source.Count; i++)
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
                    if (tmp.Count > 0)
                    {
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
                    if (source.Where(c => c.Id == itemid).First().HasChild)
                    {
                        tlDropDownes.Add(itemid, tlDropDown[itemid]);

                    }

                }
                var fsdf = tlDropDownes.Count();
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

                var res = _context.WebShellOperation(userId, xmlOut);
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
                    ParentId = int.Parse(groupId),
                    IsGroup = false
                });
            }
            for (int i = 0; i < shellOperationsGroup.Count; i++)
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
                    IsGroup = true
                });
            }
            var modelForView = CreateDropdownHierarchy(ManuOpList);
            return View(modelForView);
        }

        



        public PartialViewResult Tab(string id)
        {
            var userId = int.Parse(Session["userId"].ToString());
            System.Data.Entity.Core.Objects.ObjectParameter xmlOut = new System.Data.Entity.Core.Objects.ObjectParameter("xmlOut", typeof(object));
            int? operationId;
            if (id != null)
                operationId = int.Parse(id);
            else
                operationId = null;
            operationId = 1500;

            using (var _context = new Entities())
            {
                var res = _context.WebShellTerm(userId, operationId, xmlOut);
            }
            var xmlDoc = xmlOut.Value;
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlDoc.ToString());
            var listViewSourceName = doc.GetElementsByTagName("ShellPageSource")[0].InnerText;
            var groupSourceName = doc.GetElementsByTagName("ShellPageGroupSource")[0].InnerText;
            var pageTitle = doc.GetElementsByTagName("ShellTermName")[0].InnerText;

            List<dynamic> listViews = new List<dynamic>();
            List<dynamic> groupList = new List<dynamic>();
            using (var _context = new Entities())
            {
                var listView = (IEnumerable<dynamic>)(_context.GetType().GetProperty(listViewSourceName + "s").GetValue(_context, null));
                listViews = listView.Select(o => o).Take(15).ToList();
                object[] parameters = new object[1];
                parameters[0] = operationId;
                var resp = typeof(Entities).GetMethod(groupSourceName) != null ?
                 (IEnumerable<dynamic>)(typeof(Entities).GetMethod(groupSourceName).Invoke(_context, parameters)) :
                 (IEnumerable<dynamic>)(_context.GetType().GetProperty(groupSourceName + "s").GetValue(_context, null));
                groupList = resp.Select(o => o).ToList();
            }


            List<GroupingModel> resModel = new List<GroupingModel>();
            List<ListViewModel> resViewList = new List<ListViewModel>();
            foreach (var item in groupList)
            {
                resModel.Add(new GroupingModel()
                {
                    Key = item.KEY,
                    Name = item.NAME
                });
            }
            foreach (var item in listViews)
            {
                resViewList.Add(new ListViewModel
                {
                    Format = item.ShellTermFormat,
                    Id = item.ShellTermID,
                    Name = item.ShellTermName,
                    Key = item.ShellTermKey,
                    Code = item.ShellTermStatusID
                     
                });
            }
            //--------------- get Status and Type  source Values ---------------------------------

            List<DropDownModel> finRes = new List<DropDownModel>();




            List<PageSearhcModel> searhSource = new List<PageSearhcModel>();
            List<PageSortModel> sortSource = new List<PageSortModel>();



            string pageTypeSourceName = doc.GetElementsByTagName("ShellPageTypeSource")[0].InnerText;
            string pageStatusSourceName = doc.GetElementsByTagName("ShellPageStatusSource")[0].InnerText;



            var pageSearchNameSource = doc.GetElementsByTagName("ShellPageSearchName");
            var pageSearchFormatSource = doc.GetElementsByTagName("ShellPageSearchFormat");
            for (int i = 0; i < pageSearchFormatSource.Count; i++)
            {
                searhSource.Add(new PageSearhcModel
                {
                    SearchFormat = pageSearchFormatSource.Item(i).InnerText,
                    SearchName = pageSearchNameSource.Item(i).InnerText,
                });
            }

            var pageSortNameSource = doc.GetElementsByTagName("ShellPageSortName");
            var pageSortFormatSource = doc.GetElementsByTagName("ShellPageSortFormat");
            for (int i = 0; i < pageSortFormatSource.Count; i++)
            {
                sortSource.Add(new PageSortModel
                {
                    SortFormat = pageSortFormatSource.Item(i).InnerText,
                    SortName = pageSortNameSource.Item(i).InnerText,
                });
            }


            List<string> typeSource = new List<string>();
            List<string> statusSource = new List<string>();
            using (var _context = new Entities())
            {
                var typeSource_ = (IEnumerable<dynamic>)(_context.GetType().GetProperty(pageTypeSourceName + "s").GetValue(_context, null));
                var typeSourceIn = typeSource_.Select(o => o).ToList();

                var statusSource_ = (IEnumerable<dynamic>)(_context.GetType().GetProperty(pageStatusSourceName + "s").GetValue(_context, null));
                var statusSourceIn = statusSource_.Select(o => o).ToList();

                foreach (var item in typeSourceIn)
                {
                    // ???????????????? for specific calss only, need to by dynamic
                    typeSource.Add(item.ShellTermTypeName);
                }

                foreach (var item in statusSourceIn)
                {
                    // ???????????????? for specific calss only, need to by dynamic
                    statusSource.Add(item.ShellTermStatusName);
                }

            }

            finRes.Add(new DropDownModel
            {
                ListView = resViewList,
                LeftGroupModelList = resModel,
                PageTitle = pageTitle,
                TypeSource = typeSource,
                StatusSource = statusSource,
                PageSearchSource = searhSource,
                PaegSortSource = sortSource
            });
            return PartialView(finRes); 
        }





        public ActionResult GetListView(int? operationId)
        {
            var userId = int.Parse(Session["userId"].ToString());
            System.Data.Entity.Core.Objects.ObjectParameter xmlOut = new System.Data.Entity.Core.Objects.ObjectParameter("xmlOut", typeof(object));
            operationId = 1500;

            using (var _context = new Entities())
            {
                var res = _context.WebShellTerm(userId, operationId, xmlOut);
            }
            var xmlDoc = xmlOut.Value;
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlDoc.ToString());
                var listViewSourceName = doc.GetElementsByTagName("ShellPageSource")[0].InnerText;
            List<dynamic> listViews = new List<dynamic>();
            List<ListViewModel> resViewList = new List<ListViewModel>();
            
            using (var _context = new Entities())
            {
                var listView = (IEnumerable<dynamic>)(_context.GetType().GetProperty(listViewSourceName + "s").GetValue(_context, null));
                listViews = listView.Select(o => o).ToList();
                foreach (var item in listViews)
                {
                    resViewList.Add(new ListViewModel
                    {
                        Format = item.ShellTermFormat,
                        Id = item.ShellTermID,
                        Name = item.ShellTermName,
                        Key = item.ShellTermKey,
                        Code = item.ShellTermStatusID, 
                        GroupId = item.ShellTermGroupID

                    });
                }
                return Json(new { data = resViewList }, JsonRequestBehavior.AllowGet);
            }
        }


        public ActionResult GetGroupList(int? operationId)
        {
            var userId = int.Parse(Session["userId"].ToString());
            System.Data.Entity.Core.Objects.ObjectParameter xmlOut = new System.Data.Entity.Core.Objects.ObjectParameter("xmlOut", typeof(object));
            operationId = 1500;

            using (var _context = new Entities())
            {
                var res = _context.WebShellTerm(userId, operationId, xmlOut);
            }
            var xmlDoc = xmlOut.Value;
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlDoc.ToString());
            var groupSourceName = doc.GetElementsByTagName("ShellPageGroupSource")[0].InnerText;
            List<dynamic> groupList = new List<dynamic>();
            List<GroupingModel> resGroupList = new List<GroupingModel>();
            object[] parameters = new object[1];
            parameters[0] = operationId;
            using (var _context = new Entities())
            {
                var resp = typeof(Entities).GetMethod(groupSourceName) != null ?
                  (IEnumerable<dynamic>)(typeof(Entities).GetMethod(groupSourceName).Invoke(_context, parameters)) :
                  (IEnumerable<dynamic>)(_context.GetType().GetProperty(groupSourceName + "s").GetValue(_context, null));
                groupList = resp.Select(o => o).ToList();
                foreach (var item in groupList)
                {
                    resGroupList.Add(new GroupingModel
                    {
                       
                        Key = (item.ID).ToString(),
                        Name = item.NAME,            

                    });
                }
                return Json(new { data = resGroupList }, JsonRequestBehavior.AllowGet);
            }
        }



        public ActionResult GetListView2(int? operationId)
        {
            var userId = int.Parse(Session["userId"].ToString());
            System.Data.Entity.Core.Objects.ObjectParameter xmlOut = new System.Data.Entity.Core.Objects.ObjectParameter("xmlOut", typeof(object));
            operationId = 1500;

            using (var _context = new Entities())
            {
                var res = _context.WebShellTerm(userId, operationId, xmlOut);
            }
            var xmlDoc = xmlOut.Value;
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlDoc.ToString());
            var listViewSourceName = doc.GetElementsByTagName("ShellPageSource")[0].InnerText;
            List<dynamic> listViews = new List<dynamic>();
            List<ListViewModel> resViewList = new List<ListViewModel>();

            using (var _context = new Entities())
            {
                var listView = (IEnumerable<dynamic>)(_context.GetType().GetProperty(listViewSourceName + "s").GetValue(_context, null));
                listViews = listView.Select(o => o).ToList();
                foreach (var item in listViews)
                {
                    resViewList.Add(new ListViewModel
                    {
                        Format = item.ShellTermFormat,
                        Id = item.ShellTermID,
                        Name = item.ShellTermName,
                        Key = item.ShellTermKey,
                        Code = item.ShellTermStatusID

                    });
                }
                return Json(new { data = resViewList }, JsonRequestBehavior.AllowGet);
            }
        }


        public ActionResult GetGroupList2(int? operationId)
        {
            var userId = int.Parse(Session["userId"].ToString());
            System.Data.Entity.Core.Objects.ObjectParameter xmlOut = new System.Data.Entity.Core.Objects.ObjectParameter("xmlOut", typeof(object));
            operationId = 1500;

            using (var _context = new Entities())
            {
                var res = _context.WebShellTerm(userId, operationId, xmlOut);
            }
            var xmlDoc = xmlOut.Value;
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlDoc.ToString());
            var groupSourceName = doc.GetElementsByTagName("ShellPageGroupSource")[0].InnerText;
            List<dynamic> groupList = new List<dynamic>();
            List<GroupingModel> resGroupList = new List<GroupingModel>();
            object[] parameters = new object[1];
            parameters[0] = operationId;
            using (var _context = new Entities())
            {
                var resp = typeof(Entities).GetMethod(groupSourceName) != null ?
                  (IEnumerable<dynamic>)(typeof(Entities).GetMethod(groupSourceName).Invoke(_context, parameters)) :
                  (IEnumerable<dynamic>)(_context.GetType().GetProperty(groupSourceName + "s").GetValue(_context, null));
                groupList = resp.Select(o => o).ToList();
                foreach (var item in groupList)
                {
                    resGroupList.Add(new GroupingModel
                    {

                        Key = item.KEY,
                        Name = item.NAME,

                    });
                }
                return Json(new { data = resGroupList }, JsonRequestBehavior.AllowGet);
            }
        }


    }
}