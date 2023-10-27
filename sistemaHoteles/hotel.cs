using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
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
                //txtHotel.Text = hotel.nombre;
                rtxtHotelDesc.Text = hotel.descripcion;
                txtUbi.Text = hotel.ubicacion;
                txtDir.Text = hotel.direccion;
                txtCon.Text = hotel.telefono;
                imgs = hotel.imagenes;
                Console.WriteLine(string.Join(";", imgs));
                imgHotel.Image = new Bitmap(imgs[0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int currentImg;
        private void select1_Click(object sender, EventArgs e)
        {
            int index = currentImg - 1;
            Console.WriteLine(index);
            Console.WriteLine($"Actual: {currentImg}");

            if (index >= 0)
            {
                imgHotel.Image.Dispose();
                imgHotel.Image = new Bitmap(imgs[index]);
                currentImg = index;
            }
        }

        private void select2_Click(object sender, EventArgs e)
        {
            int index = currentImg + 1;
            Console.WriteLine(index);
            Console.WriteLine($"Actual: {currentImg}");

            if (index < imgs.Length)
            {
                imgHotel.Image.Dispose();
                imgHotel.Image = new Bitmap(imgs[index]);
                currentImg = index;
            }
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Seleccionar imagen";
            dialog.Filter = "Image Files(*.PNG;*.JPG)|*.PNG;*.JPG|All files (*.*)|*.*";
            dialog.Multiselect = true;

            if(dialog.ShowDialog() == DialogResult.OK)
            {   
                imgs = dialog.FileNames;
                imgHotel.Image.Dispose();
                imgHotel.Image = new Bitmap(imgs[0]);
                currentImg = 0;
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                hotelBLL hotel = new hotelBLL();
                hotel.id = idHotel;
               // hotel.nombre = txtHotel.Text;
                hotel.descripcion = rtxtHotelDesc.Text;
                hotel.ubicacion = txtUbi.Text;
                hotel.direccion = txtDir.Text;
                hotel.telefono = txtCon.Text;
                hotel.imagenes = imgs;

                imgHotel.Image.Dispose();
                hotel.modifyFields();
                MessageBox.Show("Se ha modificado el hotel exitosamente, para visualizar los cambios vuelva a cargar el apartado", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rtxtHotelDesc_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files != null && files.Length != 0)
            {
                rtxtHotelDesc.Text = files[0];
            }
        }

        private void openTxt_Click(object sender, EventArgs e)
        {
            OpenFileDialog txtFile = new OpenFileDialog();
            txtFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            txtFile.Title = "Arrastre un archivo de texto a la caja de texto que contiene la descripción";
            
            if (txtFile.ShowDialog() == DialogResult.OK)
            {
                string txt = File.ReadAllText(txtFile.FileName);
                if(txt.Length > 1500 || txt.Length < 10)
                {
                    MessageBox.Show("La longitud del contenido del archivo es inaceptable, porfavor modifique el archivo o seleccione otro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                
                rtxtHotelDesc.Text = txt;
            }
        }
    }
}
