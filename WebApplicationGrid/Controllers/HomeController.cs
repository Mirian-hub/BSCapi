using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using WebApplicationGrid.Models;

namespace WebApplicationGrid.Controllers
{
    public class HomeController : Controller
    {
       
               int modelNum = 3;

        public List<Type> types = new List<Type>();
        public Type[] GetTypesInNamespace(Assembly assembly, string nameSpace)
        { 
            return
                assembly.GetTypes()
                        .Where(t => String.Equals(t.Namespace, nameSpace, StringComparison.Ordinal))
                        .ToArray();
        }

        protected void GetTypes()
        {
            types = GetTypesInNamespace(Assembly.GetExecutingAssembly(), "WebApplicationGrid.Models").ToList();
        }

        BSCOperationsDto op = new BSCOperationsDto();
        //BSCTestT tmpMod = new BSCTestT();
        //PropertyInfo[] propertyInfos_ = typeof(BSCOperations).GetProperties();

        
        protected void SetOparationsValuesAndNames()
        {
           
            GetTypes();
            Type type = types[modelNum];
            PropertyInfo[] propertyInfos = type.GetProperties();
            int propertyCount = propertyInfos.Count();
            List<string> propertyDataTypes = new List<string>(); 
            foreach (var item in propertyInfos)
            {
                propertyDataTypes.Add(item.PropertyType.FullName);
            }

            op.PropertyDataTypes = propertyDataTypes;
            List<object> values = new List<object>();


            for (int i = 0; i < propertyCount; i++)
            {
                values.Add(type.GetProperties().GetValue(i));
            }

            var _context = new BSCdbEntities4();


            List<List<object>> propNames = new List<List<object>>();
            int counter = 1;
            var test1 = type.Name;
            var test2 = _context.GetType();
            var test3 = test2.GetProperty(type.Name + "s");

            //            var type_ = object;
           // var gentype = typeof(DbSet<>).MakeGenericType(type.GetType());
            //  var tmp = (IOrderedQueryable)Activator.CreateInstance(gentype);

            var _values = (IEnumerable<object>)test3.GetValue(_context, null);
            foreach (var item in propertyInfos)
            {


                propNames.Add(_values.Select(o => item.GetValue(o, null)).ToList());
                counter++;
            }
            op.PropertyValues = propNames.ToList();

            List<string> res = new List<string>();

            for (int i = 0; i < propertyInfos.Length; i++)
            {
                res.Add(propertyInfos[i].Name);
            }
            op.PropNames = res;

        }
        public ActionResult Index()
        {
            using (var _context = new BSCdbEntities4())
            {
                var optest = _context.BscOperations;
                //op.Opearations = _context.BscOperations.ToList();
                SetOparationsValuesAndNames();
                GetTypes();
            }
            ViewBag.Model = op;
            return View(op);
        }


        public ActionResult Save(string Sourse)
        {
            GetTypes();
            Type type = types[modelNum];
            PropertyInfo[] propertyInfos = type.GetProperties();
            string dbSetPropertyName = propertyInfos[0].ReflectedType.Name + "s";
            int propertyCount = propertyInfos.Count();

            var source = Sourse.Split(',').ToList();
            source.RemoveAt(source.Count() - 1);
            source.RemoveAt(source.Count() - 1);

            List<string> dotNetTypes = new List<string>(){ "Byte", "SByte", "Int32","UInt32",
                                                                "Int16", "UInt16","Int64","UInt64",
                                                                "Single","Double","Char","Boolean","Object",
                                                                 "String" ,"Decimal","DateTime"};
            //   
            int nextPropCondition = 0;
            object res;
            foreach (var prop in propertyInfos)
            {
                var propName = prop.PropertyType.FullName;
                int counterInt = 0;


                // Nullable Int64  
                if (propName.Contains("Int64") && propName.Contains("Null"))
                {
                    res = new List<Int64?>();
                    var finRes = (List<Int64?>)res;
                    //List<int?> nullableList = res.Cast<int?>().ToList();

                    foreach (var item in source)
                    {
                        if (counterInt == nextPropCondition || (counterInt) % propertyCount == nextPropCondition)
                        {
                            if (item.Count() == 0)
                                // if type in string add null else 0
                                finRes.Add(0);
                            else
                                // switch
                                finRes.Add(Int64.Parse(item));
                        }
                        counterInt++;

                    }

                    using (var _context = new BSCdbEntities4())
                    {

                        dynamic idsTEst = _context.GetType().GetProperty(dbSetPropertyName).GetValue(_context, null); //Select(o => o.ID).ToList();
                        var idsFinal = new List<int>();
                        foreach (var item in idsTEst)
                        {
                            idsFinal.Add(item.ID);
                        }
                        int counter2 = 0;
                        foreach (var item in idsFinal)
                        {
                            var operationTypeToUpdate = ((IEnumerable<dynamic>)idsTEst).Where(o => o.ID == item).First();
                            operationTypeToUpdate.GetType().GetProperty(prop.Name).SetValue(operationTypeToUpdate, finRes[counter2]); //res[counter2];
                            counter2++;
                        }
                        counter2 = 0;
                        _context.SaveChanges();
                    }
                }
                // Nullable Int32
                if (propName.Contains("Int32") && propName.Contains("Null"))
                {
                    res = new List<Int32?>();
                    var finRes = (List<Int32?>)res;
                    //List<int?> nullableList = res.Cast<int?>().ToList();

                    foreach (var item in source)
                    {
                        if (counterInt == nextPropCondition || (counterInt) % propertyCount == nextPropCondition)
                        {
                            if (item.Count() == 0)
                                // if type in string add null else 0
                                finRes.Add(0);
                            else
                                // switch
                                finRes.Add(Int32.Parse(item));
                        }
                        counterInt++;

                    }

                    using (var _context = new BSCdbEntities4())
                    {
                        dynamic idsTEst = _context.GetType().GetProperty(dbSetPropertyName).GetValue(_context, null); //Select(o => o.ID).ToList();
                        var idsFinal = new List<int>();
                        foreach (var item in idsTEst)
                        {
                            idsFinal.Add(item.ID);
                        }

                        int counter2 = 0;
                        foreach (var item in idsFinal)
                        {
                            var operationTypeToUpdate = ((IEnumerable<dynamic>)idsTEst).Where(o => o.ID == item).First();
                            operationTypeToUpdate.GetType().GetProperty(prop.Name).SetValue(operationTypeToUpdate, finRes[counter2]); //res[counter2];
                            counter2++;
                        }
                        counter2 = 0;
                        _context.SaveChanges();
                    }
                }

                // int not nullable 
                if (propName.Contains("Int") && !propName.Contains("Null"))
                {
                    res = new List<int>();
                    var finRes = (List<int>)res;
                    //List<int?> nullableList = res.Cast<int?>().ToList();

                    foreach (var item in source)
                    {
                        if (counterInt == nextPropCondition || (counterInt) % propertyCount == nextPropCondition)
                        {
                            if (item.Count() == 0)
                                // if type in string add null else 0
                                finRes.Add(0);
                            else
                                // switch
                                finRes.Add(int.Parse(item));
                        }
                        counterInt++;

                    }

                    using (var _context = new BSCdbEntities4())
                    {
                        dynamic idsTEst = _context.GetType().GetProperty(dbSetPropertyName).GetValue(_context, null); //Select(o => o.ID).ToList();
                        var idsFinal = new List<int>();
                        foreach (var item in idsTEst)
                        {
                            idsFinal.Add(item.ID);
                        }

                        int counter2 = 0;
                        foreach (var item in idsFinal)
                        {
                            var operationTypeToUpdate = ((IEnumerable<dynamic>)idsTEst).Where(o => o.ID == item).First();
                            operationTypeToUpdate.GetType().GetProperty(prop.Name).SetValue(operationTypeToUpdate, finRes[counter2]); //res[counter2];
                            counter2++;
                        }
                        counter2 = 0;
                        _context.SaveChanges();
                    }
                }




                // if property type is string 
                int counterString = 0;
                if (propName.Contains("String"))
                {
                    res = new List<string>();
                    var finRes = (List<string>)res;

                    foreach (var item in source)
                    {
                        if (counterString == nextPropCondition || (counterString) % propertyCount == nextPropCondition)
                        {
                            if (item.Count() == 0)
                                // if type in string add null else 0
                                finRes.Add(null);
                            else
                                // switch
                                finRes.Add(item);
                        }
                        counterString++;
                    }

                    using (var _context = new BSCdbEntities4())
                    {
                        dynamic idsTEst = _context.GetType().GetProperty(dbSetPropertyName).GetValue(_context, null); //Select(o => o.ID).ToList();
                        var idsFinal = new List<int>();
                        foreach (var item in idsTEst)
                        {
                            idsFinal.Add(item.ID);
                        }

                        int counter2 = 0;
                        foreach (var item in idsFinal)
                        {
                            var operationTypeToUpdate = ((IEnumerable<dynamic>)idsTEst).Where(o => o.ID == item).First();
                            operationTypeToUpdate.GetType().GetProperty(prop.Name).SetValue(operationTypeToUpdate, finRes[counter2]); //res[counter2];
                            counter2++;
                        }
                        counter2 = 0;
                        _context.SaveChanges();
                    }
                }



                nextPropCondition++;
            }

            return RedirectToAction("GetOperations");
        }






    }
}