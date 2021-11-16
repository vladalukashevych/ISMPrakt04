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
    public partial class While3 : Form
    {
        public While3()
        {
            InitializeComponent();
        }

        private void ButtonAction_Click(object sender, EventArgs e)
        {
            int p;
            bool correctP = int.TryParse(TextBoxP.Text, out p);
            if (p <=0) correctP = false;
            if (correctP == false)
            {
                MessageBox.Show("Incorrect data entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {                
                double[] Arr = While.CycleWhile3(p);
                TextBoxResult.Text = $"Sportsman spent {Arr[0]} days running and riched a mark of {Arr[1]} km";
                TextBoxResult.Visible = true;
                LabelResult.Visible = true;
            }
        }
    }
}
