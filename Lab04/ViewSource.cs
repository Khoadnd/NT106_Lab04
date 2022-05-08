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
    public partial class ViewSource : Form
    {
        public ViewSource(string data)
        {
            InitializeComponent();
            rtxtSource.Text = data;
        }

        private void ViewSource_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.Collect();
        }
    }
}
