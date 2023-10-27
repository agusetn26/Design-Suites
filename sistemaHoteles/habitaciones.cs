using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using sistemaHoteles.BLL;

namespace sistemaHoteles
{
    public partial class habitaciones : Form
    {
        private int idHotel;
        private int currentType;
        public habitaciones(int id)
        {
            idHotel = id;
            InitializeComponent();
        }

        private void habitaciones_Load(object sender, EventArgs e)
        {
            try
            {
                habitacionesBLL bllIns = new habitacionesBLL();

                DataSet data = bllIns.fillList(idHotel);
                DataTable listData = data.Tables[0];

                lstTipo.DataSource = listData;
                lstTipo.DisplayMember = "nombre";
                lstTipo.ValueMember = "id_tipoHabitacion";

                bllIns.id = listData.Rows[0].Field<int>("id_tipoHabitacion");
                bllIns.setData();
                setCurrentFields(bllIns);
                currentType = 0;

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void changeType()
        {
            DataRowView type = (DataRowView) lstTipo.SelectedItem;
            habitacionesBLL bllIns = new habitacionesBLL();
            bllIns.id = (int) type.Row["id_tipoHabitacion"];
            bllIns.setData();  

            setCurrentFields(bllIns);
        }

        private void setCurrentFields(habitacionesBLL roomIns)
        {
            txtDesc.Text = roomIns.descripcion;
            numOcupacion.Value = roomIns.ocupacion;
            numDimensiones.Value = (decimal) roomIns.dimensiones;
            numPrecio.Value = roomIns.precio;
            numHabitaciones.Value = roomIns.habitaciones;
            imgs = roomIns.imagenes;
            imgHabitacion.Image = new Bitmap(imgs[0]);
        }

        private void lstTipo_Click(object sender, EventArgs e)
        {
            if (lstTipo.SelectedIndex != currentType)
            {
                currentType = lstTipo.SelectedIndex;
                changeType();
            }
        }

        private int currentImg = 0;
        private string[] imgs;
        private void select1_Click(object sender, EventArgs e)
        {
            int index = currentImg - 1;
            Console.WriteLine(index);
            Console.WriteLine($"Actual: {currentImg}");

            if (index >= 0)
            {
                imgHabitacion.Image.Dispose();
                imgHabitacion.Image = new Bitmap(imgs[index]);
                currentImg = index;
            }
        }

        private void select2_Click(object sender, EventArgs e)
        {
            int index = currentImg + 1;
            Console.WriteLine(index);
            Console.WriteLine($"Actual: {currentImg}");

            if (index < imgs.Length)
            {
                imgHabitacion.Image.Dispose();
                imgHabitacion.Image = new Bitmap(imgs[index]);
                currentImg = index;
            }
        }

        private void openTxt_Click(object sender, EventArgs e)
        {
            OpenFileDialog txtFile = new OpenFileDialog();
            txtFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            txtFile.Title = "Seleccione un archivo de texto";

            if (txtFile.ShowDialog() == DialogResult.OK)
            {
                string txt = File.ReadAllText(txtFile.FileName);
                if (txt.Length > 5000 || txt.Length < 10)
                {
                    MessageBox.Show("La longitud del contenido del archivo es inaceptable, porfavor modifique el archivo o seleccione otro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                txtDesc.Text = txt;
            }
        }
    }
}
