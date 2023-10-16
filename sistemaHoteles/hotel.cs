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
                rtxtHotelDesc.Text = hotel.descripcion;
                rtbHeight(rtxtHotelDesc);
                
            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void rtbHeight(RichTextBox rtb)
        {
            int lineHeight = (int)(rtxtHotelDesc.Font.GetHeight() * 2); // Estimación del tamaño de una línea de texto
            int lineCount = rtxtHotelDesc.GetLineFromCharIndex(rtxtHotelDesc.Text.Length) + 1;

            int newHeight = (lineHeight * lineCount) + rtxtHotelDesc.Margin.Vertical + 2; // Ajustes para el margen y el borde

            if (newHeight > rtxtHotelDesc.Height)
            {
                rtxtHotelDesc.Height = newHeight;
            }
        }
    }
}
