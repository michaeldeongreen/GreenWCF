using GreenWCF.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenWCF.Services
{
    public class SomeService : ISomeService
    {
        public string Print()
        {
            return "Printing....";
        }
    }
}
