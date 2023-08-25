using System;
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
    public partial class menu : Form
    {
        private baseForm currentBaseIns;
        public menu(baseForm form)
        {
            InitializeComponent();
            currentBaseIns = form;
        }

        private void hoteles(object sender, EventArgs e)
        {
            currentBaseIns.changeForm(new hoteles(currentBaseIns));            
        }
        private void transacciones(object sender, EventArgs e)
        {
            currentBaseIns.changeForm(new transacciones(currentBaseIns));
        }
        
        private void proveedores(object sender, EventArgs e)
        {
            currentBaseIns.changeForm(new proveedores(currentBaseIns));
        }
        
        private void productos(object sender, EventArgs e)
        {
            currentBaseIns.changeForm(new productos(currentBaseIns));
        }
    }
}
