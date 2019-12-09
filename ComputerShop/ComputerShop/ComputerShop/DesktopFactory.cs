using ComputerShop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop
{
    public class DesktopFactory : iComputerFactory
    {
        public IComputer CreateComputer()
        {
            return new Desktop();
        }

        public IRAM CreateRAM()
        {
            return new DIMM();
        }

        public IStorage CreateStorage()
        {
            return new SATA();
        }
    }
}
