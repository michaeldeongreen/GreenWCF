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
        private readonly IThatService _thatService;
        public SomeService(IThatService thatService)
        {
            _thatService = thatService;
        }
        public string Print()
        {
            return $"In SomeService and {_thatService.Print()}";
        }
    }
}
