﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class Hienthiketquamonan : Form
    {
        public Hienthiketquamonan(Control selectedControl)
        {
            InitializeComponent();
            flowLayoutPanel1.Controls.Add(selectedControl);
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
