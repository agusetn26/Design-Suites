using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using sistemaPrincipal.BLL;

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
            hotelBLL hotelBll = datosForm();
            if(hotelBll != null)
            {
                picTimer.Stop();
                displayImage.Image.Dispose();
                pictureBox1.Enabled = false;
                hotelBll.crearHotel();
            }
        }

        private hotelBLL datosForm()
        {

            if (string.IsNullOrWhiteSpace(nombre.Text)    || string.IsNullOrWhiteSpace(descripcion.Text) || string.IsNullOrWhiteSpace(ubicacion.Text) ||
                string.IsNullOrWhiteSpace(direccion.Text) || string.IsNullOrWhiteSpace(telefono.Text)    ||
                 displayImage.Image == null
               )
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return null;
            }
            try
            {
                hotelBLL hotel = new hotelBLL
                               (
                                nombre.Text,
                                descripcion.Text,
                                ubicacion.Text,
                                direccion.Text,
                                telefono.Text,
                                categoria.Text,
                                (string[])displayImage.Tag
                               );
                return hotel;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            picTimer.Stop();

            OpenFileDialog images = new OpenFileDialog();
            images.Multiselect = true;
            images.Filter = "Images (*.JPG;*.PNG;)|*.JPG;*.PNG;|" + "All files (*.*)|*.*";
            images.Title = "Selecciona imagenes representativas del hotel";
            

            if(images.ShowDialog() == DialogResult.OK)
            {

                if (images.FileNames.Length > 1)
                {
                    int i = 0;
                    displayImage.Tag = images.FileNames;
                    picTimer.Start();
                    picTimer.Tick += (s, args) =>
                    {
                        if (i == images.FileNames.Length)
                            i = 0;

                        string ruta = images.FileNames[i];
                        displayImage.Image = new Bitmap(ruta);
                        displayImage.Refresh();
                        displayImage.Image.Dispose();
                        i++;
                    };
                }
                else
                {
                    displayImage.Tag = images.FileNames;
                    displayImage.Image = new Bitmap(images.FileName);
                }
            }
            else
            {
                if (displayImage.Image != null)
                {
                    displayImage.Image.Dispose();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
