using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using sistemaPrincipal.BLL;

namespace sistemaPrincipal
{
    public partial class formularioProveedor : Form
    {
        private baseForm currentBaseIns;
        public formularioProveedor(baseForm form)
        {
            InitializeComponent();
            currentBaseIns = form;
        }
        private void back(object sender, EventArgs e)
        {
            currentBaseIns.changeForm(new proveedores(currentBaseIns));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            proveedorBLL proveedor = datosForm();
            if (proveedor != null)
            {
                if (!proveedor.crearProveedor())
                {
                    MessageBox.Show("Hubo un error con la confirmación del formulario. De persistir contactar con soporte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Se añadió un nuevo producto. Volver al apartado anterior para visualizar", "Success");
                pictureBox1.Enabled = false;
            }
        }
        private proveedorBLL datosForm()
        {

            if (string.IsNullOrWhiteSpace(nombre.Text) || string.IsNullOrWhiteSpace(direccion.Text) || string.IsNullOrWhiteSpace(contacto.Text) ||
                string.IsNullOrWhiteSpace(oferta.Text) || string.IsNullOrWhiteSpace(envio.Text)
               )
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return null;
            }
            proveedorBLL proveedores = new proveedorBLL
                                (
                                 nombre.Text,
                                 direccion.Text,
                                 contacto.Text,
                                 oferta.Text,
                                 envio.Text
                                );
            return proveedores;

        }
    }
}
