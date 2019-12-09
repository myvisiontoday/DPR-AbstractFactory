using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop
{
    public class Desktop : IComputer
    {
        public string getDescription()
        {
            return "New Inspiration Dell Desktop \n" +
                    "* 8th Generation Intel® Core™ i7-8565U Processor \n" +
                    "* Windows 10 Home";
        }
    }
}
