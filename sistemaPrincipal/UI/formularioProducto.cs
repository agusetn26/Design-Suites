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
    public partial class formularioProducto : Form
    {
        private baseForm currentBaseIns;
        private productosDAL dal;
        public formularioProducto(baseForm form)
        {
            InitializeComponent();
            currentBaseIns = form;
            dal = new productosDAL();
            fillComboBox();
        }

        private void fillComboBox()
        {
            var tablaProveedores = dal.selectProveedores().Tables[0];
            
            proveedores.DataSource = tablaProveedores;
            proveedores.DisplayMember = tablaProveedores.Columns["nombre"].ColumnName;
            proveedores.ValueMember = tablaProveedores.Columns["id_proveedor"].ColumnName;
        }

        private void back(object sender, EventArgs e)
        {
            currentBaseIns.changeForm(new productos(currentBaseIns));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            productoBLL productosBLL = datosForm();
            if(productosBLL != null)
            {
                Console.WriteLine(proveedores.SelectedValue);
                if (!productosBLL.crearProducto()){
                    MessageBox.Show("Hubo un error con la confirmación del formulario. De persistir contactar con soporte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Se añadió un nuevo producto. Volver al apartado anterior para visualizar", "Success");
                pictureBox1.Enabled = false;
            }
        }

        private productoBLL datosForm()
        {

            if (string.IsNullOrWhiteSpace(productoNombre.Text) || string.IsNullOrWhiteSpace(categoria.Text) || string.IsNullOrWhiteSpace(coste.Text) || displayImage.Image == null)
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return null;
            }
            try
            {
                Console.WriteLine(proveedores.SelectedValue);
                productoBLL producto = new productoBLL
                           (
                            productoNombre.Text,
                            categoria.Text,
                            (int)proveedores.SelectedValue,
                            coste.Text,
                          (string)displayImage.Tag
                           );
                return producto;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog imgs = new OpenFileDialog();
            imgs.Filter = "Images (*.JPG;*.PNG;)|*.JPG;*.PNG;|" + "All files (*.*)|*.*";
            imgs.Title = "Selecciona imágenes representativas del hotel";

            if (imgs.ShowDialog() == DialogResult.OK)
            {
                displayImage.Image = null;
                displayImage.Image = new Bitmap(imgs.FileName);
                displayImage.Tag = imgs.FileName;
            }
        }
    }
}
