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
    public partial class For3 : Form
    {
        public For3()
        {
            InitializeComponent();
        }

        private void ButtonAction_Click(object sender, EventArgs e)
        {
            double A;
            bool correctA = double.TryParse(TextBoxA.Text, out A);
            if (A % 1 == 0) correctA = false;
            int N;
            bool correctN = int.TryParse(TextBoxN.Text, out N);
            if (N <= 0) correctN = false;
            if (correctA == false || correctN == false)
            {
                MessageBox.Show("Incorrect data entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                TextBoxPow.Text = For.CycleFor3(A, N).ToString();
                LabelPow.Visible = true;
                TextBoxPow.Visible = true;
            }
        }
    }
}
