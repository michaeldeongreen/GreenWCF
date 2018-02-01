using GreenWCF.Services;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace GreenWCF.DependencyResolution
{
    public static class IoC
    {
        public static IContainer Initialize()
        {
            var registry = new Registry();
            registry.IncludeRegistry<ServicesRegistry>();
            registry.IncludeRegistry<DefaultRegistry>();
            var container = new Container(registry);
            return container;
        }
    }
}