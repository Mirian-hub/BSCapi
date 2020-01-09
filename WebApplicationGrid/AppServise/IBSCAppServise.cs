using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WebApplicationGrid.AppServise
{
    public interface IBSCAppServise
    {
       Type[] GetTypesInNamespace(Assembly assembly, string nameSpace);
    }
}
