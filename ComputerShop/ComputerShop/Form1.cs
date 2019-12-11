using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerShop
{
    public partial class Form1 : Form
    {
        private Shop shop;
        private string _s3cretCode = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radiobtnDesktop.Checked)
            {
                iComputerFactory factory = new DesktopFactory();
                shop = new Shop(factory);
                label1.Text = shop.CreateAndDisplay();
            }
            else if (radiobtnLaptop.Checked)
            {
                iComputerFactory factory = new LaptopFactory();
                shop = new Shop(factory);
                label1.Text = shop.CreateAndDisplay();
            }
            else
                MessageBox.Show("Please select the device you want.");
        }

        private void radiobtnDesktop_CheckedChanged(object sender, EventArgs e)
        {
            radiobtnSODIMM.Enabled = false;
            radiobtneSATA.Enabled = false;

            radiobtnSATA.Enabled = true;
            radiobtnDIMM.Enabled = true;
        }

        private void radiobtnLaptop_CheckedChanged(object sender, EventArgs e)
        {
            radiobtnSODIMM.Enabled = true;
            radiobtneSATA.Enabled = true;

            radiobtnSATA.Enabled = false;
            radiobtnDIMM.Enabled = false;
        }
    }
}
