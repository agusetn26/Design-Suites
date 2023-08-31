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
        private hotelDAL dal;
        public hoteles(baseForm form)
        {
            dal = new hotelDAL();
            currentBaseIns = form;
            InitializeComponent();
            tableContent();
        }

        private void tableContent()
        {
            DataSet rows = dal.select();
            contenedorHoteles.DataSource = rows.Tables[0];
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
