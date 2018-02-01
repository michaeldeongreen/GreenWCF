using GreenWCF.Services;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Web;

namespace GreenWCF.DependencyResolution
{
    public class StructureMapServiceHostFactory : ServiceHostFactory
    {
        public StructureMapServiceHostFactory()
        {
            IContainer container = IoC.Initialize();
            StructureMapWcf.StructureMapDependencyScope = new StructureMapDependencyScope(container);
        }

        protected override ServiceHost CreateServiceHost(Type serviceType, Uri[] baseAddresses)
        {
            return new StructureMapServiceHost(serviceType, baseAddresses);
        }
    }
}