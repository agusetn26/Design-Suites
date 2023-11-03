using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

using sistemaHoteles.BLL;

namespace sistemaHoteles.UI
{
    public partial class suministro : Form
    {
        private int idHotel;
        public suministro(int idH)
        {
            idHotel = idH;
            InitializeComponent();
            fillProducts();
        }

        private void fillProducts()
        {
            try
            {
                suministroBLL bll = new suministroBLL();
                DataTable src = bll.bringProducts(idHotel);
                DataTable newSrc = new DataTable();

                newSrc.Columns.Add("Producto", typeof(Image));
                newSrc.Columns.Add("Stock", typeof(string));
                newSrc.Columns.Add("id", typeof(int));
                newSrc.Columns.Add("nombre", typeof(string));

                foreach (DataRow item in src.Rows)
                {
                    Image image = Image.FromFile(item.Field<string>("imagen"));
                    string stock = item.Field<string>("stock");
                    int iden = item.Field<int>("id_suministro");
                    string nombre = item.Field<string>("nombre");

                    newSrc.Rows.Add(image, stock, iden, nombre);
                }

                dgvProducts.DataSource = newSrc;
                dgvProducts.Columns["Producto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvProducts.Columns["id"].Visible = false;
                dgvProducts.Columns["nombre"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int idProduct;
        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                DataGridViewSelectedRowCollection row = dgvProducts.SelectedRows;
                string producto = (string)row[0].Cells["nombre"].Value;
                int id = (int)row[0].Cells["id"].Value;
            
                idProduct = id;
                lblNombre.Text = producto;
                numStock.Value = 0;
            } 
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (numStock.Value == 0)
            {
                MessageBox.Show("La cantidad minima para realizar el pedido del producto es mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                suministroBLL suministro = new suministroBLL();
                suministro.id = idProduct;
                suministro.nombre = lblNombre.Text;
                suministro.cantidad = (int)numStock.Value;
                suministro.newQuery();

                MessageBox.Show($"Se ha solicitado la cantidad de [{suministro.cantidad}] del producto [{suministro.nombre}]", "Success", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
