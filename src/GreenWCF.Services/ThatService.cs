using GreenWCF.Services.Interfaces;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenWCF.Services
{
    public class ThatService : IThatService
    {
        private readonly IContainer _container;
        public ThatService(IContainer container)
        {
            _container = container;
            var t = container;
        }
        public string Print()
        {
            return "In ThatService";
        }
    }
}
