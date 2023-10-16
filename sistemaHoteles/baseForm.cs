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

            config conn = new config();
            DataSet hotelesData = conn.returnData("SELECT * FROM hoteles");

            DataTable hotelesTable = hotelesData.Tables[0];
            lstHotel.DataSource = hotelesTable;
            lstHotel.DisplayMember = "nombre";
            lstHotel.ValueMember = "id_hotel";

            selectedHotel = (int) lstHotel.SelectedValue;
            Console.WriteLine(conn.GetState());
        }
        public void openForm(Form form)
        {
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
            openForm(new reservas());
        }

        private void habitaciones_Click(object sender, EventArgs e)
        {
            openForm(new habitaciones());
        }

        private void lstHotel_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string msg = "¿Está seguro de cambiar de hotel?\n Se borrán cambios no guardados sobre la información del hotel";
            DialogResult option = MessageBox.Show(msg, "Cambiar de cadena", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
           
            if(option == DialogResult.No)
            {
                lstHotel.SelectedValue = selectedHotel;
                return;
            }

            selectedHotel = (int)lstHotel.SelectedValue;
        }
    }
}
