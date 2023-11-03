using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using sistemaHoteles.BLL;

namespace sistemaHoteles
{
    public partial class reservas : Form
    {
        private int idHotel;
        private DataTable src;
        private Dictionary<string, int> startRecord;
        public reservas(int id)
        {
            idHotel = id;
            startRecord = new Dictionary<string, int>();
            startRecord["Habitaciones"] = 0;
            startRecord["Eventos"] = 0;

            InitializeComponent();
            bringTableHeaders("Habitaciones");
            cbOptions.SelectedItem = "Habitaciones";
        }

        private void bringTableHeaders(string op)
        {
            reservasBLL bll = new reservasBLL();
            DataTable table = bll.bringHeaders(op);
            src = table;
            dgvReservas.DataSource = src;
        }
        
        private void bringTableRows()
        {
            string current = (string)cbOptions.SelectedItem;

            reservasBLL bll = new reservasBLL();
            DataTable table = bll.bringRows(idHotel, startRecord[current], current);
            foreach (DataRow row in table.Rows)
            {
                src.Rows.Add(row.ItemArray);
            }
            startRecord[current] += 2;
            Console.WriteLine(startRecord[current]);
        }
        private void cbOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvReservas.Refresh();
            bringTableHeaders((string)cbOptions.SelectedItem);
            bringTableRows();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            bringTableRows();
        }

        private void placeHolder(object sender, EventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            txtBox.Text = "";
        }

        private void place(object sender, EventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            string holder = txtBox.Tag.ToString();
            txtBox.Text = holder;
        }
    }
}
