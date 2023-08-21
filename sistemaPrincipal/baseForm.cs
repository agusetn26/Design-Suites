using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace sistemaPrincipal
{
    public partial class baseForm : Form
    {
        public Form currentForm = null;
        public baseForm()
        {
            InitializeComponent();
            changeForm(new menu(this));
        }

        public void changeForm(Form newForm)
        {
            releaseForm(currentForm);
           
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;
            newForm.BackgroundImage = this.body.BackgroundImage;
            newForm.BackgroundImageLayout = ImageLayout.Stretch;

            currentForm = newForm;
            this.body.Controls.Add(currentForm);
            this.body.Tag = currentForm;

            currentForm.Show();
        }

        private void releaseForm(Form lastForm)
        {
            if (currentForm != null)
            {
                body.Controls.Clear();
                lastForm.Close();
                lastForm.Dispose();
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
