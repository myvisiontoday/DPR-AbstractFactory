﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop
{
    public interface IRAM
    {
        string getDescription();
        void setCapactiy(int capacity);
        decimal getPrice();

    }
}
