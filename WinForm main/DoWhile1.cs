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
    public partial class DoWhile1 : Form
    {
        public DoWhile1()
        {
            InitializeComponent();
        }

        int sum = 0;
        private void ButtonAction_Click(object sender, EventArgs e)
        {
            int n;
            bool correctN = int.TryParse(TextBoxNumber.Text, out n);
            if (correctN == false)
            {
                MessageBox.Show("Incorrect data entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (n == 0)
                {
                    TextBoxSum.Text = $"{sum}";
                    TextBoxSum.Visible = true;
                    LabelSum.Visible = true;
                    sum = 0;
                }
                else
                {
                    sum += n;
                }
            }
        }
    }
}
