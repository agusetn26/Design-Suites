using System;
using System.Windows.Forms;

namespace sistemaPrincipal
{
    public partial class formularioHotel : Form
    {
        private baseForm currentBaseIns;
        public formularioHotel(baseForm form)
        {
            InitializeComponent();
            currentBaseIns = form;
        }

        private void back(object sender, EventArgs e)
        {
            currentBaseIns.changeForm(new hoteles(currentBaseIns));
        }
    }
}
