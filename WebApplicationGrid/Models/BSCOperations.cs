using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace WebApplicationGrid.Models
{
    public class BSCOperations
    {
        public IEnumerable<BSCTestT> Opearations { get; set; }
        public List<string> PropNames { get; set; }
        public List<List<object>> PropertyValues { get; set; }
        public List<object> FinalPropertyValues { get; set; }
        public string Sourse { get; set; }
        
    }

}
