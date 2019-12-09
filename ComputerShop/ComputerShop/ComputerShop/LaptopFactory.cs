using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop
{
    class LaptopFactory : iComputerFactory
    {
        public IComputer CreateComputer()
        {
            return new Laptop();
        }

        public IRAM CreateRAM()
        {
            return new SODIMM();
        }

        public IStorage CreateStorage()
        {
            return new mSATA();
        }
    }
}
