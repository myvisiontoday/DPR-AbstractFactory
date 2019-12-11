using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop
{
    public class mSATA : IStorage
    {
        private int capacity = 250; // default value
        public string getDescription()
        {
            return "* " + this.capacity + "GB SSD M.2 PCIe NVMe mSATA";
        }

        public decimal getPrice()
        {
            return 150;
        }

        public void setCapactiy(int capacity)
        {
            this.capacity = capacity;
        }
    }
}
