﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Detallles_Orden : Form
    {
        public Detallles_Orden()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ordenes ordenes = new Ordenes();
            ordenes.Show();
            this.Hide();
        }
    }
}
