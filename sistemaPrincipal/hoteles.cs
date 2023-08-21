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
    public partial class hoteles : Form
    {
        private baseForm currentBaseIns;
        public hoteles(baseForm form)
        {
            InitializeComponent();
            currentBaseIns = form;
        }

        private void back(object sender, EventArgs e)
        {
            currentBaseIns.changeForm(new menu(currentBaseIns));
        }

        private void addHotel(object sender, EventArgs e)
        {
            currentBaseIns.changeForm(new formularioHotel(currentBaseIns));
        }
    }
}
