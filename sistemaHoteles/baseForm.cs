using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaHoteles
{
    public partial class baseForm : Form
    {
        public Form currentForm;
        public baseForm()
        {
            InitializeComponent();
        }

        public void openForm(Form form)
        {
            basePanel.Controls.Clear();

            currentForm = form;
            currentForm.TopLevel = false;
            currentForm.FormBorderStyle = FormBorderStyle.None;
            currentForm.Dock = DockStyle.Fill;
            basePanel.Controls.Add(currentForm);
            currentForm.Show();
        }

        private void btnHoteles_Click(object sender, EventArgs e)
        {
            openForm(new hoteles());
        }

        private void reservas_Click(object sender, EventArgs e)
        {
            openForm(new reservas());
        }
    }
}
