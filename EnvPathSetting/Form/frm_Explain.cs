﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnvPathSetting
{
    public partial class frm_Explain : Form
    {
        public frm_Explain()
        {
            InitializeComponent();
        }

        private void frm_Explain_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
