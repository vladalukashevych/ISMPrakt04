using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace WinForm_main
{
    public partial class While2 : Form
    {
        public While2()
        {
            InitializeComponent();
        }

        private void ButtonAction_Click(object sender, EventArgs e)
        {
            int n;
            bool correctN = int.TryParse(TextBoxN.Text, out n);
            if (n <= 1) correctN = false;
            if (correctN == false)
            {
                MessageBox.Show("Incorrect data entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                TextBoxK.Text = While.CycleWhile2(n).ToString();
                TextBoxK.Visible = true;
                LabelK.Visible = true;
            }
        }
    }
}
