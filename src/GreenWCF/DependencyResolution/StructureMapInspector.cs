using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
using System.Web;

namespace GreenWCF.DependencyResolution
{
    public class StructureMapInspector : IDispatchMessageInspector
    {
        public object AfterReceiveRequest(ref Message request, IClientChannel channel, InstanceContext instanceContext)
        {
            StructureMapWcf.StructureMapDependencyScope.CreateNestedContainer();
            return null;
        }

        public void BeforeSendReply(ref Message reply, object correlationState)
        {
            StructureMapWcf.StructureMapDependencyScope.DisposeNestedContainer();
        }
    }
}