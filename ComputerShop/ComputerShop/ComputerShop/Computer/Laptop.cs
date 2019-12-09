using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop
{
    public class Laptop : IComputer
    {
        public string getDescription()
        {
            return "New XPS Dell Laptop\n" +
                        "* 10th Generation Intel® Core™ i7-8565U Processor \n" +
                        "* Windows 10 Home";
        }
    }
}
