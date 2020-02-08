using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using WebApplicationGrid.AppServise;
using WebApplicationGrid.Models;
using Microsoft.Extensions.DependencyInjection;

namespace WebApplicationGrid.Controllers
{
    public class BSCController : Controller
    {
      public ActionResult GetManu()
        {
            System.Data.Entity.Core.Objects.ObjectParameter xmlOut = new System.Data.Entity.Core.Objects.ObjectParameter("xmlOut", typeof(object));

            using (var _context = new Entities())
            {

                var res = _context.WebShellOperation(0,xmlOut);
            }
            var finRes = xmlOut.Value;
            return View();
        }

    }
}