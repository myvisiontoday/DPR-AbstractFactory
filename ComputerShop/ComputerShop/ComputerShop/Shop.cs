using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop
{
    public class Shop
    {
        private iComputerFactory factory;
        public Shop(iComputerFactory computerFactory)
        {
            this.factory = computerFactory;
        }

        public String CreateAndDisplay()
        {
            IComputer computer = factory.CreateComputer();
            IRAM RAM = factory.CreateRAM();
            IStorage storage = factory.CreateStorage();

            return "Your " + computer.getDescription() +
                "/n " + RAM.getDescription() +
                "/n " + storage.getDescription();
        }
    }
}
