using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop
{
    public interface iComputerFactory
    {
        IComputer CreateComputer();
        IRAM CreateRAM();
        IStorage CreateStorage();
    }
}
