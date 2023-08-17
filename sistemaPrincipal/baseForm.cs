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
        public baseForm()
        {
            InitializeComponent();
            this.Paint += degradado;
        }

        private void degradado(object sender, PaintEventArgs e)
        {
            //Configuracion para el formuario
            Color startColorForm = Color.FromArgb(3, 116, 180);
            Color endColorForm = Color.FromArgb(1, 134, 209);

            //Configuracion para el titulo
            Color startColorTitle = Color.FromArgb(235, 235, 235);
            Color endColorTitle = Color.FromArgb(194, 191, 191);

            LinearGradientBrush degradadoForm = new LinearGradientBrush(this.ClientRectangle, startColorForm, endColorForm, LinearGradientMode.Horizontal);
            LinearGradientBrush degradadoTitle = new LinearGradientBrush(title.ClientRectangle, startColorTitle, endColorTitle, LinearGradientMode.Horizontal);
            
            e.Graphics.FillRectangle(degradadoForm, this.ClientRectangle);
            e.Graphics.FillRectangle(degradadoTitle, title.ClientRectangle);
        }
    }
}
