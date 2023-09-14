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
    public partial class productos : Form
    {
        private baseForm currentBaseIns;
        private productosDAL dal;
        private Dictionary<int, DataGridViewRow> filasModificadas = new Dictionary<int, DataGridViewRow>();
        public productos(baseForm form)
        {
            InitializeComponent();
            currentBaseIns = form;
            dal = new productosDAL();
            tableFill();
        }
        private void back(object sender, EventArgs e)
        {
            currentBaseIns.changeForm(new menu(currentBaseIns));
        }

        private void tableFill()
        {
            contenedorProductos.DataSource = dal.select().Tables[0];
            contenedorProductos.Columns["id_producto"].ReadOnly = true;
            contenedorProductos.Columns["fecha_alta"].ReadOnly = true;
        }


        private void addProduct(object sender, EventArgs e)
        {
            currentBaseIns.changeForm(new formularioProducto(currentBaseIns));
        }

        private void addRow(DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = contenedorProductos.Rows[e.RowIndex];
            int idProducto = (int)fila.Cells["id_producto"].Value;
            
            if (filasModificadas.ContainsKey(idProducto))
            {
                filasModificadas[idProducto] = fila;
            }
            else
            {
                filasModificadas.Add(idProducto, fila);
            }
        }

        private void contenedorProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                switch (contenedorProductos.Columns[e.ColumnIndex].Name)
                {
                    case "imagen":
                        OpenFileDialog imgs = new OpenFileDialog();
                        imgs.Filter = "Images (*.JPG;*.PNG;)|*.JPG;*.PNG;|" + "All files (*.*)|*.*";
                        imgs.Title = "Selecciona una imagen para el producto";

                        if (imgs.ShowDialog() == DialogResult.OK)
                        {
                            string file = imgs.FileName;

                            contenedorProductos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = file;

                            MessageBox.Show("Cambio exitoso, para guardar los cambios presione editar", "Success", MessageBoxButtons.OK);
                            addRow(e);
                        }
                        else
                        {
                            MessageBox.Show("No se han realizado cambio de imagen", "State", MessageBoxButtons.OK);
                        }
                        break;
                        
                    case "eliminar":
                        DialogResult confirmar = MessageBox.Show("¿Estás seguro de que quieres eliminar este producto?", "State", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (confirmar == DialogResult.Yes)
                        {
                            contenedorProductos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = DateTime.Now.ToString();
                            addRow(e);
                        }
                        else
                        {
                            contenedorProductos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "Dar de baja";
                            addRow(e);
                        }

                        break;

                    default:
                        break;
                }
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (filasModificadas.Count == 0)
            {
                MessageBox.Show("Cambie el contenido de una fila para actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (var producto in filasModificadas)
            {
                productoBLL productoBll = new productoBLL(producto.Key,
                                              producto.Value.Cells["nombre"].Value.ToString(),
                                              producto.Value.Cells["categoria"].Value.ToString(),
                                              producto.Value.Cells["costeU"].Value.ToString(),
                                              producto.Value.Cells["imagen"].Value.ToString(),
                                              producto.Value.Cells["id_proveedor"].Value.ToString(),
                                              producto.Value.Cells["fecha_alta"].Value.ToString(),
                                              producto.Value.Cells["eliminar"].Value.ToString());
                if (!productoBll.modificarProducto())
                {
                    string msg = $"Error al actualizar el producto con el id {productoBll.attrId}, cambie los archivos de imagen. De persistir contacte con soporte";
                    MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
            }
            MessageBox.Show("Se han modificado los productos correctamente");
            filasModificadas.Clear();
            this.tableFill();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void contenedorProductos_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            addRow(e);
        }
    }
}
