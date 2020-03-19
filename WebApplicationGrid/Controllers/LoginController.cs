using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        //------------------------------------------------------------- Call Store procedure as Entity Method ----------------------------------------------------- 



        //public ActionResult Register(UserVModel user)
        //{
        //    System.Data.Entity.Core.Objects.ObjectParameter xmlOut = new System.Data.Entity.Core.Objects.ObjectParameter("xmlOut", typeof(object));

        //    using (var _context = new Entities())
        //    {

        //        var res = _context.WebShellUser(user.Name,user.Password, xmlOut);
        //    }
        //    var finRes = xmlOut.Value;

        //    XmlDocument doc = new XmlDocument();
        //    doc.LoadXml(finRes.ToString());
        //    var userKey = doc.GetElementsByTagName("ShellMessageKey")[0].InnerText;
        //    var userId = doc.GetElementsByTagName("ShellUserID")[0].InnerText;




        //    if ( Int32.Parse(userKey) >= 0)
        //    {
        //        Session["userId"] = userId;
        //        return RedirectToAction("Index", "Manu");
        //    }
        //    else
        //    {
        //        user.ErrorMessage = "User Name or Password is incorrest !";
        //        return View("Index", user);
        //    }
        //}


        //--------------------------------------------------------------------- Call Store Procedure Execute Store Query ------------------------------------------------------------- 

        public ActionResult Register(UserVModel user)
        {
           // System.Data.Entity.Core.Objects.ObjectParameter xmlOut = new System.Data.Entity.Core.Objects.ObjectParameter("xmlOut", typeof(object));
            SqlParameter userKey = new SqlParameter("@ShellUserKey", user.Name);
            SqlParameter UserPassword = new SqlParameter("@ShellUserPassword", user.Password);
            SqlParameter xmlOut = new SqlParameter
            {
                ParameterName = "@xmlOut",
                SqlDbType = System.Data.SqlDbType.Xml,
                Direction = System.Data.ParameterDirection.Output
            };

            using (var _context = new Entities())
            {

                var res = _context.Database.ExecuteSqlCommand("WebShellUser @ShellUserKey, @ShellUserPassword, @xmlOut OUTPUT", userKey, UserPassword, xmlOut); /*WebShellUser(user.Name, user.Password, xmlOut);*/
            }
            var finRes = xmlOut.Value;

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(finRes.ToString());
            var _userKey = doc.GetElementsByTagName("ShellMessageKey")[0].InnerText;
            var userId = doc.GetElementsByTagName("ShellUserID")[0].InnerText;




            if (Int32.Parse(_userKey) >= 0)
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