using GreenWCF.DependencyResolution;
using GreenWCF.Services.Interfaces;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace GreenWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class GreenService : IGreenService
    {
        private readonly ISomeService _someService;
        public GreenService(ISomeService someService, IContainer container)
        {
            _someService = someService;
        }
        public string Get(int value)
        {
            return $"You entered: {value} and {_someService.Print()} and your container is: {StructureMapWcf.StructureMapDependencyScope.CurrentNestedContainer.GetHashCode().ToString()}";
        }
    }
}
