using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using sistemaPrincipal.DAL;

namespace sistemaPrincipal
{
    public partial class hoteles : Form
    {
        private baseForm currentBaseIns;
        private baseDeDatos db;
        public hoteles(baseForm form)
        {
            db = new baseDeDatos();
            currentBaseIns = form;
            InitializeComponent();
            tableContent();
        }

        private void tableContent()
        {
            contenedorHoteles.DataSource = db.consultas().Tables[0];
            DataGridViewCheckBoxColumn checkboxCol = new DataGridViewCheckBoxColumn();
            checkboxCol.HeaderText = "seleccionar";
            checkboxCol.Name = "seleccionar";
            checkboxCol.ReadOnly = false;
            contenedorHoteles.Columns.Add(checkboxCol);
        }

        private void back(object sender, EventArgs e)
        {
            currentBaseIns.changeForm(new menu(currentBaseIns));
        }

        private void addHotel(object sender, EventArgs e)
        {
            currentBaseIns.changeForm(new formularioHotel(currentBaseIns));
        }

        private void contenedorHoteles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
