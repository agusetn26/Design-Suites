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
using sistemaPrincipal.BLL;

namespace sistemaPrincipal
{
    public partial class hoteles : Form
    {
        private baseForm currentBaseIns;
        private hotelDAL dal;
        private Dictionary<int, DataGridViewRow> filasModificadas = new Dictionary<int, DataGridViewRow>();
        public hoteles(baseForm form)
        {
            dal = new hotelDAL();
            currentBaseIns = form;
            InitializeComponent();
            tableContent();
        }
        private void back(object sender, EventArgs e)
        {
            currentBaseIns.changeForm(new menu(currentBaseIns));
        }

        private void tableContent()
        {
            DataSet rows = dal.select();
            contenedorHoteles.DataSource = rows.Tables[0];
            contenedorHoteles.Columns["id_hotel"].ReadOnly = true;
            contenedorHoteles.Columns["apertura"].ReadOnly = true;
            contenedorHoteles.Columns["cerrar"].ReadOnly = true;
        }

        private void addRow(DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = contenedorHoteles.Rows[e.RowIndex];
            int idHotel = (int)fila.Cells["id_hotel"].Value;

            if (filasModificadas.ContainsKey(idHotel))
            {
                filasModificadas[idHotel] = fila;
            }
            else
            {
                filasModificadas.Add(idHotel, fila);
            }
        }
        private void contenedorHoteles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0) {
                switch (contenedorHoteles.Columns[e.ColumnIndex].Name)
                {
                    case "imagen":
                        OpenFileDialog imgs = new OpenFileDialog();
                        imgs.Multiselect = true;
                        imgs.Filter = "Images (*.JPG;*.PNG;)|*.JPG;*.PNG;|" + "All files (*.*)|*.*";
                        imgs.Title = "Selecciona imágenes representativas del hotel";

                        if (imgs.ShowDialog() == DialogResult.OK)
                        {
                            string files = string.Join(";", imgs.FileNames);

                            contenedorHoteles.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = files;

                            MessageBox.Show("Cambio exitoso, para guardar los cambios presione editar", "Success", MessageBoxButtons.OK);
                            addRow(e);
                        }
                        else
                        {
                            MessageBox.Show("No se han realizado cambios de imagen", "State", MessageBoxButtons.OK);
                        }
                        break;

                    case "cerrar":
                        DialogResult confirmar = MessageBox.Show("¿Estás seguro de que quieres cerrar este hotel?", "State", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                     
                        if (confirmar == DialogResult.Yes)
                        {
                            contenedorHoteles.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = DateTime.Now.ToString();
                            addRow(e);
                        }
                        else {
                            contenedorHoteles.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "Establecer fecha de cierre";
                            addRow(e);
                        }

                        break;

                    default:
                        break;
                }
            }
        }


        private void contenedorHoteles_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            addRow(e);
        }
        private void addHotel(object sender, EventArgs e)
        {
            currentBaseIns.changeForm(new formularioHotel(currentBaseIns));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (filasModificadas.Count == 0)
            {
                MessageBox.Show("Cambie el contenido de una fila para actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (var hot in filasModificadas)
            {
                hotelBLL hotel;
                try
                {
                    hotel = new hotelBLL(hot.Key,
                                            hot.Value.Cells["nombre"].Value.ToString(),
                                            hot.Value.Cells["descripcion"].Value.ToString(),
                                            hot.Value.Cells["ubicacion"].Value.ToString(),
                                            hot.Value.Cells["direccion"].Value.ToString(),
                                            hot.Value.Cells["telefono"].Value.ToString(),
                                            hot.Value.Cells["imagen"].Value.ToString(),
                                            hot.Value.Cells["cerrar"].Value.ToString());
                } catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
              
                if (!hotel.modificarHotel())
                {
                    string msg = $"Error al actualizar el hotel con el id {hotel.attrId}, cambie los archivos de imagen. De persistir contacte con soporte";
                    MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            MessageBox.Show("Se han modificado los hoteles correctamente");
            filasModificadas.Clear();
            this.tableContent();
        }

    }
}
