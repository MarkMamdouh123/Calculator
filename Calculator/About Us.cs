﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class aboutUsForm : Form
    {
        public aboutUsForm()
        {
            InitializeComponent();
        }

        private void returnToCalc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
