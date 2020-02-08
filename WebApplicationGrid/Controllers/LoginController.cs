using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using WebApplicationGrid.Models;
using WebApplicationGrid.ViewModels;

namespace WebApplicationGrid.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Register(UserVModel user)
        {
            System.Data.Entity.Core.Objects.ObjectParameter xmlOut = new System.Data.Entity.Core.Objects.ObjectParameter("xmlOut", typeof(object));

            using (var _context = new Entities())
            {

                var res = _context.WebShellUser(user.Name,user.Password, xmlOut);
            }
            var finRes = xmlOut.Value;
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(finRes.ToString());
            var userKey = doc.GetElementsByTagName("ShellMessageKey")[0].InnerText;
            var userId = doc.GetElementsByTagName("ShellUserID")[0].InnerText;




            if ( Int32.Parse(userKey) >= 0)
            {
                Session["userId"] = userId;
                return RedirectToAction("Index", "Manu");
            }
            else
            {
                user.ErrorMessage = "User Name or Password is incorrest !";
                return View("Index", user);
            }
        }
    }
}