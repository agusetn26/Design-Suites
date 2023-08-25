using System;
using System.Windows.Forms;
using sistemaPrincipal.BLL;
using sistemaPrincipal.DAL;

namespace sistemaPrincipal
{
    public partial class formularioHotel : Form
    {
        private baseForm currentBaseIns;
        public formularioHotel(baseForm form)
        {
            InitializeComponent();
            currentBaseIns = form;
        }

        private void back(object sender, EventArgs e)
        {
            currentBaseIns.changeForm(new hoteles(currentBaseIns));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(datosForm());
        }

        private hotelBLL datosForm()
        {
            hotelBLL hotel = new hotelBLL();

            if (string.IsNullOrWhiteSpace(nombre.Text) || string.IsNullOrWhiteSpace(descripcion.Text) || string.IsNullOrWhiteSpace(ubicacion.Text) ||
        string.IsNullOrWhiteSpace(direccion.Text) || string.IsNullOrWhiteSpace(telefono.Text) || string.IsNullOrWhiteSpace(gerente.Text) ||
        string.IsNullOrWhiteSpace(categoria.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                return null;
            }
          
                hotel.attrNombre = nombre.Text;
                hotel.attrDescripcion = descripcion.Text;
                hotel.attrUbicacion = ubicacion.Text;
                hotel.attrDireccion = direccion.Text;
                hotel.attrTelefono = telefono.Text;
                hotel.attrGerente = gerente.Text;
                hotel.attrCategoria = categoria.Text;

                return hotel;

        }
    }
}
