using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GreenWCF.DependencyResolution
{
    public class DefaultRegistry : Registry
    {
        public DefaultRegistry()
        {
            Scan(scan => {
                scan.TheCallingAssembly();
                scan.WithDefaultConventions();
            });
        }
    }
}