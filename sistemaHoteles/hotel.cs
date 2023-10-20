using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistemaHoteles.BLL;

namespace sistemaHoteles
{
    public partial class hotel : Form
    {
        private int idHotel;
        private string[] imgs;
        public hotel(int id)
        {
            idHotel = id;
            InitializeComponent();
   
            fillData();
        }

        private void fillData()
        {
            try
            {
                hotelBLL hotel = new hotelBLL();
                hotel.getFields(idHotel);
                txtHotel.Text = hotel.nombre;
                rtxtHotelDesc.Text = hotel.descripcion.Replace("\\n", "\r\n");
                txtUbi.Text = hotel.ubicacion.Replace("\\n", "\r\n");
                txtDir.Text = hotel.direccion.Replace("\\n", "\r\n");
                txtCon.Text = hotel.telefono.Replace("\\n", "\r\n");
                imgs = hotel.imagenes;
                imgHotel.Image = new Bitmap(imgs[0]);

                rtbHeight(rtxtHotelDesc);
            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rtbHeight(RichTextBox rtb)
        {
            int lineHeight = (int)(rtxtHotelDesc.Font.GetHeight() * 1.8); // Estimación del tamaño de una línea de texto
            int lineCount = rtxtHotelDesc.GetLineFromCharIndex(rtxtHotelDesc.Text.Length) + 1;

            int newHeight = (lineHeight * lineCount) + rtxtHotelDesc.Margin.Vertical + 2; // Ajustes para el margen y el borde

            if (newHeight > rtxtHotelDesc.Height)
            {
                rtxtHotelDesc.Height = newHeight;
            }
        }

        private int currentImg;
        private void select1_Click(object sender, EventArgs e)
        {
            int index = currentImg - 1;

            if (index > 0)
            {
                imgHotel.Image.Dispose();
                imgHotel.Image = new Bitmap(imgs[index]);
                currentImg = index;
            }
        }

        private void select2_Click(object sender, EventArgs e)
        {
            int index = currentImg + 1;

            if (index < (imgs.Length - 1))
            {
                imgHotel.Image.Dispose();
                imgHotel.Image = new Bitmap(imgs[index]);
                currentImg = index;
            }
        }
    }
}
