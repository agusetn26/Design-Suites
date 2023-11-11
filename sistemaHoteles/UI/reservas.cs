using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using sistemaHoteles.DAL;
using sistemaHoteles.BLL;

namespace sistemaHoteles
{
    public partial class reservas : Form
    {
        private reservaHabitacionesBLL bllRooms;
        private reservaEventosBLL bllEvents;
        private Reservas currentObj;
        public reservas(int idHotel)
        {
            bllRooms = new reservaHabitacionesBLL(idHotel, 2);
            bllEvents = new reservaEventosBLL(idHotel, 2);

            InitializeComponent();
            cbOptions.SelectedItem = "Habitaciones";
        }
        
        private void setHeaders()
        {
            currentObj.pagesAmount();
            dgvReservas.DataSource = currentObj.bringHeaders();
            numCurrentPage.Maximum = currentObj.totalPages;
            numCurrentPage.Value = currentObj.page;
            lblTotalPages.Text = "/" + currentObj.totalPages.ToString();
        }

        private void cbOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbOptions.SelectedIndex == 0)
            {
                currentObj = bllRooms;
                setHeaders();
            }
            else
            {
                currentObj = bllEvents;
                setHeaders();
            }
            dgvReservas.Refresh();
        }

        private void placeHolder(object sender, EventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            txtBox.Text = "";
        }

        private void place(object sender, CancelEventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            Console.WriteLine(txtBox.Text);
            if (txtBox.Text == "")
            {
                string holder = txtBox.Tag.ToString();
                txtBox.Text = holder;
            }
        }

        private void newSrc(DataTable tbl)
        {
            if (tbl != null)
            {
                dgvReservas.Refresh();

                dgvReservas.DataSource = tbl;
                numCurrentPage.Value = currentObj.page;
                lblTotalPages.Text = "/" + currentObj.totalPages;
            }
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            int to = currentObj.page + 1;
            if (to <= currentObj.totalPages)
            {
                numCurrentPage.Value = currentObj.page + 1;
            }
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            int to = currentObj.page - 1;
            if (to > 0)
            {
                numCurrentPage.Value = to;
            }
        }

        private void numCurrentPage_ValueChanged(object sender, EventArgs e)
        {
            int toPage = (int) numCurrentPage.Value;
            DataTable table = currentObj.jumpTo(toPage);
            newSrc(table);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string txt = txtSearch.Text;

            if (txt != "Código...")
            {
                /*
                Type objectType = currentObj.GetType();
                currentObj = (Paginador)Activator.CreateInstance(objectType);
                */
                newSrc(currentObj.lookFor(txt));
            }
            else
            {
                setHeaders();
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRows = dgvReservas.SelectedRows
                    .Cast<DataGridViewRow>() // Dada herencia y polimorfismo de clases, el compilador trata a la colección como instancias. No como la clase de colección
                    .Select(row => "'" + row.Cells["Codigo"].Value + "'");  //  Debido a esto, es posible recorrer cada valor. Creando una nueva colección de elementos

                string reservaCodes = string.Join(",", selectedRows);
                currentObj.acceptState(reservaCodes);
                DataTable table = currentObj.jumpTo((int)numCurrentPage.Value);
                newSrc(table);

                MessageBox.Show("Se ha cambiado el estado de las reservas exitosamente", "Success", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRows = dgvReservas.SelectedRows
                    .Cast<DataGridViewRow>() // Dada herencia y polimorfismo de clases, el compilador trata a la colección como instancias. No como la clase de colección
                    .Select(row => "'" + row.Cells["Codigo"].Value + "'");  //  Debido a esto, es posible recorrer cada valor. Creando una nueva colección de elementos

                string reservaCodes = string.Join(",", selectedRows);
                currentObj.rejectState(reservaCodes);
                DataTable table = currentObj.jumpTo((int)numCurrentPage.Value);
                newSrc(table);

                MessageBox.Show("Se ha cambiado el estado de las reservas exitosamente", "Success", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
