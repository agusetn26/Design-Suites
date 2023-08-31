﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaPrincipal
{
    public partial class formularioProducto : Form
    {
        private baseForm currentBaseIns;
        public formularioProducto(baseForm form)
        {
            InitializeComponent();
            currentBaseIns = form;
        }

        private void back(object sender, EventArgs e)
        {
            currentBaseIns.changeForm(new productos(currentBaseIns));
        }
    }
}