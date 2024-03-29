﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop
{
    public class DIMM : IRAM
    {
        private int capacity = 4; // default value
        public string getDescription()
        {
            return "* "+this.capacity + "GB LPDDR3 2133MHz DIMM";
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
