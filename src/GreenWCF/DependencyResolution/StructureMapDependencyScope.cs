using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GreenWCF.DependencyResolution
{
    public class StructureMapDependencyScope
    {
        public IContainer Container { get; private set; }
        public StructureMapDependencyScope(IContainer container)
        {
            if (container == null)
                throw new ArgumentNullException("container");
            Container = container;
        }
    }
}