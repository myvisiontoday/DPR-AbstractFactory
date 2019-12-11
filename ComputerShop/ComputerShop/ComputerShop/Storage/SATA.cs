using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop
{
    public class SATA : IStorage
    {
        private int capacity = 2; // default value
        public string getDescription()
        {
            return "* " + this.capacity + "TB Hard Drive NVMe SATA";
        }

        public decimal getPrice()
        {
            return 50;
        }

        public void setCapactiy(int capacity)
        {
            this.capacity = capacity;
        }
    }
}
