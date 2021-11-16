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
    public partial class For4 : Form
    {
        public For4()
        {
            InitializeComponent();
        }

        private void ActionButton_Click(object sender, EventArgs e)
        {
            int a;
            bool correctA = int.TryParse(aTextBox.Text, out a);
            int b;
            bool correctB = int.TryParse(bTextBox.Text, out b);
            bool OK = false;
            if (a < b) OK = true;
            if (correctA == false || correctB == false || OK == false)
            {
                MessageBox.Show("Incorrect data entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SumTextBox.Text = For.CycleFor4(a, b).ToString();
                SumTextBox.Visible = true;
                SumLabel.Visible = true;
            }
        }
    }
}
