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
    public partial class eventos : Form
    {
        private int idHotel;
        private int selectedEvent;
        private bool locked;
        private List<string> eventosExistentes;
        private DataTable currentSrc;
        private string[] imgs;
        public eventos(int id)
        {
            idHotel = id;
            selectedEvent = -1;
            locked = false;
            eventosExistentes = new List<string>();
            InitializeComponent();
            listComponents();
        }

        public void listComponents()
        {
            try
            {
                eventosBLL ins = new eventosBLL();
                DataTable data = ins.bringHeaders(idHotel);
                currentSrc = data;
                lstConfig(currentSrc);
                lstEventos.SelectedIndex = selectedEvent;

                for(int i=0; i<data.Rows.Count; i++)
                {
                    eventosExistentes.Add((string)data.Rows[i]["nombre"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void lstConfig(object src)
        {
            lstEventos.Refresh();
            lstEventos.DataSource = src;
            lstEventos.DisplayMember = "nombre";
            lstEventos.ValueMember = "id_evento";
        }
        public void formData(int idEvento)
        {
            eventosBLL evento = new eventosBLL();
            evento.id = idEvento;
            evento.fillData();
            txtNombre.Text = evento.nombre;
            rtxtDesc.Text = evento.descripcion;
            numPrecio.Value = evento.precio;
            txtAlta.Text = evento.fAlta;
            txtBaja.Text = evento.fBaja;
            imgs = evento.imagenes;
            imgEvento.Image = new Bitmap(imgs[0]);
        }

        private void lstEventos_Click(object sender, EventArgs e)
        {
            if(lstEventos.SelectedIndex != selectedEvent)
            {
                if (!locked) { 
                    selectedEvent = lstEventos.SelectedIndex;
                    object valueMember = lstEventos.SelectedValue;
                    formData((int)valueMember);
                }
                else
                {
                    MessageBox.Show("Complete el formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lstEventos.SelectedIndex = selectedEvent;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtEvento.Text.Length > 0)
            {
                if (!eventosExistentes.Contains(txtEvento.Text))
                {
                    locked = true;
                    currentSrc.Rows.Add("0", txtEvento.Text);
                    lstEventos.SelectedIndex = (currentSrc.Rows.Count - 1);
                    selectedEvent = (currentSrc.Rows.Count - 1);
                    lstConfig(currentSrc);

                    imgEvento.Image = null;
                    imgs = null;
                    txtNombre.Text = txtEvento.Text;
                    txtEvento.Text = "";
                    rtxtDesc.Text = "";
                    numPrecio.Value = 0;
                    txtAlta.Text = DateTime.Now.ToString();
                    txtBaja.Text = "";
                }
            }
        }

        private int currentImg = 0;
        private void select2_Click(object sender, EventArgs e)
        {
            int i = currentImg + 1;
            if(i < imgs.Length)
            {
                currentImg = i;
                imgEvento.Image = new Bitmap(imgs[i]);
            }
        }

        private void select1_Click(object sender, EventArgs e)
        {
            int i = currentImg - 1;
            if (i > 0)
            {
                currentImg = i;
                imgEvento.Image = new Bitmap(imgs[i]);
            }
        }

        private string tmpF = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tmp");
        private void openFile_Click(object sender, EventArgs e)
        {
            Directory.Delete(tmpF, true);
            Directory.CreateDirectory(tmpF);

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;
            dialog.Filter = "Image Files(*.PNG;*.JPG)|*.PNG;*.JPG|All files (*.*)|*.*";
            dialog.Title = "Seleccionar Imagenes";
            DialogResult res = dialog.ShowDialog();


            if (res == DialogResult.OK)
            {
                if(dialog.FileNames.Length < 6)
                {
                    try
                    {
                        int loop = 0;
                        foreach (string ruta in dialog.FileNames)
                        {
                            string fName = loop + Path.GetExtension(ruta);
                            string newPath = Path.Combine(tmpF, fName);
                            File.Copy(ruta, newPath);
                            loop++;
                        }
                        currentImg = 0;
                        imgs = dialog.FileNames;
                        imgEvento.Image = new Bitmap(imgs[0]);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Directory.Delete(tmpF, true);
                        Directory.CreateDirectory(tmpF);
                        MessageBox.Show("Hubo un error en la subida de archivos, intentelo con otras imágenes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Deben ser menos de 6 imagenes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void submitEvento_Click(object sender, EventArgs e)
        {
            if (lstEventos.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un evento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtNombre.Text.Length == 0 || rtxtDesc.Text.Length == 0 || numPrecio.Value == 0 || imgs == null)
            {
                MessageBox.Show("Complete el formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Console.WriteLine(DateTime.Now.ToString());
            imgEvento.Image.Dispose();
            try
            {
                eventosBLL evento = new eventosBLL();
                evento.nombre = txtNombre.Text;
                evento.descripcion = rtxtDesc.Text;
                evento.precio = numPrecio.Value;
                evento.imagenes = imgs;
                evento.fAlta = txtAlta.Text;
                evento.fBaja = txtBaja.Text;

                if (locked)
                {
                    evento.newEvent(idHotel);
                    listComponents();
                    locked = false;
                    MessageBox.Show("Se añadió un nuevo evento a la lista", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    evento.id = (int) lstEventos.SelectedValue;
                    evento.modifyEvent();
                    listComponents();
                    MessageBox.Show("Se ha modificado el evento", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnState_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("De presionar \"Si\" se cerrará el evento\nDe presionar \"No\" se reabrirá el evento\n No se guardarán los cambios hasta que presione \"Guardar\"", "Estado del evento", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                txtBaja.Text = DateTime.Now.ToString();
            }
            else
            {
                txtBaja.Text = "";
            }
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog txtFile = new OpenFileDialog();
            txtFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            txtFile.Title = "Arrastre un archivo de texto a la caja de texto que contiene la descripción";

            if (txtFile.ShowDialog() == DialogResult.OK)
            {
                string txt = File.ReadAllText(txtFile.FileName);

                if (txt.Length > 1500 || txt.Length < 10)
                {
                    MessageBox.Show("La longitud del contenido del archivo es inaceptable, porfavor modifique el archivo o seleccione otro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                rtxtDesc.Text = txt;
            }
        }
    }
}
