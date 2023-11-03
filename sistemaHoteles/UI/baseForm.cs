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
using sistemaHoteles.UI;

namespace sistemaHoteles
{
    public partial class baseForm : Form
    {
        public Form currentForm;
        public int selectedHotel;
        public baseForm()
        {
            InitializeComponent();
        }
        private void baseForm_Load(object sender, EventArgs e)
        {
            currentForm = new Form();
            loadList();
        }

        private void loadList()
        {
            try
            {
                config conn = new config();
                DataSet hotelesData = conn.returnData("SELECT * FROM hoteles WHERE fecha_baja IS NULL");

                DataTable hotelesTable = hotelesData.Tables[0];
                lstHotel.DataSource = hotelesTable;
                lstHotel.DisplayMember = "nombre";
                lstHotel.ValueMember = "id_hotel";

                selectedHotel = (int)lstHotel.SelectedValue;
                Console.WriteLine(conn.GetState());
            } catch
            {
                MessageBox.Show("Hubo un problema de conexión con la base de datos, verifique su conexión o contactar con soporte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void openForm(Form form)
        {
            if(form.Name == currentForm.Name)
            {
                form.Close();
                form.Dispose();
                return;
            }

            basePanel.Controls.Clear();
            currentForm.Close();

            currentForm = form;
            currentForm.TopLevel = false;
            currentForm.FormBorderStyle = FormBorderStyle.None;
            currentForm.Dock = DockStyle.Fill;
            basePanel.Controls.Add(currentForm);
            currentForm.Show();
        }

        private void btnHoteles_Click(object sender, EventArgs e)
        {
            openForm(new hotel(selectedHotel));
        }

        private void reservas_Click(object sender, EventArgs e)
        {
            openForm(new reservas(selectedHotel));
        }

        private void suministros_Click(object sender, EventArgs e)
        {
            openForm(new suministro(selectedHotel));
        }

        private void habitaciones_Click(object sender, EventArgs e)
        {
            openForm(new habitaciones(selectedHotel));
        }

        private void eventos_Click(object sender, EventArgs e)
        {
            openForm(new eventos(selectedHotel));
        }

        private void lstHotel_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string msg = "¿Está seguro de cambiar de hotel?\r\nSe borrán cambios no guardados sobre la información del hotel";
            DialogResult option = MessageBox.Show(msg, "Cambiar de cadena", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
           
            if(option == DialogResult.No)
            {
                lstHotel.SelectedValue = selectedHotel;
                return;
            }

            basePanel.Controls.Clear();
            currentForm = new Form();
            selectedHotel = (int)lstHotel.SelectedValue;
        }
    }
}
