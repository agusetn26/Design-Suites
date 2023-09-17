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
    public partial class proveedores : Form
    {
        private baseForm currentBaseIns;
        private proveedoresDAL dal;
        private Dictionary<int, DataGridViewRow> filasModificadas = new Dictionary<int, DataGridViewRow>();

        public proveedores(baseForm form)
        {
            InitializeComponent();
            currentBaseIns = form;
            dal = new proveedoresDAL();
            fillTable();
        }
        private void back(object sender, EventArgs e)
        {
            currentBaseIns.changeForm(new menu(currentBaseIns));
        }

        private void fillTable()
        {
            DataSet rows = dal.select();
            contenedorProveedores.DataSource = rows.Tables[0];
            contenedorProveedores.Columns["id_proveedor"].ReadOnly = true;
            contenedorProveedores.Columns["fecha_alta"].ReadOnly = true;
            contenedorProveedores.Columns["rescindir"].ReadOnly = true;
        }

        private void addProvider(object sender, EventArgs e)
        {
            currentBaseIns.changeForm(new formularioProveedor(currentBaseIns));
        }
        private void addRow(DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = contenedorProveedores.Rows[e.RowIndex];
            int idProveedor = (int)fila.Cells["id_proveedor"].Value;

            if (filasModificadas.ContainsKey(idProveedor))
            {
                filasModificadas[idProveedor] = fila;
            }
            else
            {
                filasModificadas.Add(idProveedor, fila);
            }
        }
        private void contenedorProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                switch (contenedorProveedores.Columns[e.ColumnIndex].Name)
                {
                    case "rescindir":
                        Console.WriteLine("aaa");
                        DialogResult confirmar = MessageBox.Show("¿Estás seguro de que quieres dar de baja este proveedor? Todos los productos que provee se eliminarán.", "State", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (confirmar == DialogResult.Yes)
                        {
                            contenedorProveedores.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = DateTime.Now.ToString();
                            addRow(e);
                        }
                        else
                        {
                            contenedorProveedores.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "Rescindir contrato";
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

            foreach (var row in filasModificadas)
            {
                if (string.IsNullOrWhiteSpace(row.Value.Cells["nombre"].Value.ToString())   || string.IsNullOrWhiteSpace(row.Value.Cells["direccion"].Value.ToString()) ||
                    string.IsNullOrWhiteSpace(row.Value.Cells["contacto"].Value.ToString()) || string.IsNullOrWhiteSpace(row.Value.Cells["productos"].Value.ToString()) ||
                    string.IsNullOrWhiteSpace(row.Value.Cells["envio"].Value.ToString())   || string.IsNullOrWhiteSpace(row.Value.Cells["rescindir"].Value.ToString())
                   )
                {
                    MessageBox.Show("Se han detectado celdas vacías, cancelando actualización de listado...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                proveedorBLL proveedor = new proveedorBLL(
                                                        row.Key.ToString(),
                                                        row.Value.Cells["nombre"].Value.ToString(),
                                                        row.Value.Cells["direccion"].Value.ToString(),
                                                        row.Value.Cells["contacto"].Value.ToString(),
                                                        row.Value.Cells["productos"].Value.ToString(),
                                                        row.Value.Cells["envio"].Value.ToString(),
                                                        row.Value.Cells["rescindir"].Value.ToString()
                                                       );
                if (!proveedor.modificarProveedor())
                {
                    string msg = $"Error al actualizar el proveedor con el id {proveedor.attrId}, cambie los archivos de imagen. De persistir contacte con soporte";
                    MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            MessageBox.Show("Se han modificado los proveedores correctamente");
            filasModificadas.Clear();
            this.fillTable();
        }

        private void contenedorProveedores_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            addRow(e);
        }
    }
}
