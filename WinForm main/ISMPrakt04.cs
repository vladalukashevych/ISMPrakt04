using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_main
{
    public partial class ISMPrakt04 : Form
    {
        public ISMPrakt04()
        {
            InitializeComponent();
        }

        private void ButtonFor1_Click(object sender, EventArgs e)
        {
            For1 windowfor1 = new For1();
            windowfor1.Show();
        }

        private void ButtonFor2_Click(object sender, EventArgs e)
        {
            For2 windowfor2 = new For2();
            windowfor2.Show();
        }

        private void ButtonFor3_Click(object sender, EventArgs e)
        {
            For3 windowfor3 = new For3();
            windowfor3.Show();
        }

        private void ButtonFor4_Click(object sender, EventArgs e)
        {
            For4 windowfor4 = new For4();
            windowfor4.Show();
        }

        private void ButtonFor5_Click(object sender, EventArgs e)
        {
            For5 windowfor5 = new For5();
            windowfor5.Show();
        }
        private void ButtonWhile1_Click(object sender, EventArgs e)
        {
            While1 windowwhile1 = new While1();
            windowwhile1.Show();
        }
        private void ButtonWhile2_Click(object sender, EventArgs e)
        {
            While2 windowwhile2 = new While2();
            windowwhile2.Show();
        }
        private void ButtonWhile3_Click(object sender, EventArgs e)
        {
            While3 windowwhile3 = new While3();
            windowwhile3.Show();
        }
        private void ButtonDoWhile1_Click(object sender, EventArgs e)
        {
            DoWhile1 windowdowhile1 = new DoWhile1();
            windowdowhile1.Show();
        }
    }
}
