using System;
using System.Windows.Forms;

namespace sistemaPrincipal
{
    public partial class transacciones : Form
    {
        private baseForm currentForm;
        public transacciones(baseForm form)
        {
            InitializeComponent();
            currentForm = form;
        }

        private void back(object sender, EventArgs e)
        {
            currentForm.changeForm(new menu(currentForm));
        }
    }
}
