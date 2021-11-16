﻿using System;
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
    public partial class For2 : Form
    {
        public For2()
        {
            InitializeComponent();
        }

        private void ActionButton_Click(object sender, EventArgs e)
        {
            int n;
            bool correctN = int.TryParse(TextBoxN.Text, out n);
            if (n <= 0) correctN = false;
            if (correctN == false)
            {
                MessageBox.Show("Incorrect data entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                TextBoxSum.Text = For.CycleFor2(n).ToString();
                TextBoxSum.Visible = true;
                LabelSum.Visible = true;
            }
        }
    }
}
