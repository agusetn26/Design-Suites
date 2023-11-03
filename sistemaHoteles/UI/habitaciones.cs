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
    public partial class habitaciones : Form
    {
        private int idHotel;
        private int selectedRoom;
        private bool locked;
        private List<string> habitacionesExistentes;
        private DataTable currentSrc;
        private DataTable currentRoomsSrc;
        private string[] imgs;
        public habitaciones(int id)
        {
            idHotel = id;
            selectedRoom = 0;
            locked = false;
            habitacionesExistentes = new List<string>();
            InitializeComponent();
            cbDisplay.SelectedItem = "Imagenes";
            listComponents();
            formData((int)lstTipo.SelectedValue);
        }

        public void listComponents()
        {
            try
            {
                habitacionesBLL ins = new habitacionesBLL();
                DataTable data = ins.bringHeaders(idHotel);
                currentSrc = data;
                lstConfig(currentSrc);
                lstTipo.SelectedIndex = selectedRoom;

                for (int i = 0; i < data.Rows.Count; i++)
                {
                    habitacionesExistentes.Add((string)data.Rows[i]["nombre"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstConfig(object src)
        {
            lstTipo.Refresh();
            lstTipo.DataSource = src;
            lstTipo.DisplayMember = "nombre";
            lstTipo.ValueMember = "id_tipoHabitacion";
        }
        public void formData(int idRoom)
        {
            habitacionesBLL habitacion = new habitacionesBLL();
            habitacion.id = idRoom;
            habitacion.fillData();

            txtNombre.Text = habitacion.nombre;
            txtDesc.Text = habitacion.descripcion;
            numPrecio.Value = habitacion.precio;
            numDimensiones.Value = habitacion.dimensiones;
            numOcupacion.Value = habitacion.ocupacion;
            txtAlta.Text = habitacion.fAlta;
            imgs = habitacion.imagenes;
            imgHabitacion.Image = new Bitmap(imgs[0]);
            currentImg = 0;

            DataTableCollection tables = habitacion.roomsData(idHotel, idRoom);
            currentRoomsSrc = tables[0];
            int roomsAmount = (int)tables[1].Rows[0]["cant"];
            int roomsBaja = (int)tables[1].Rows[0]["baja"];
            int currentRooms = roomsAmount - roomsBaja;

            lblActualRooms.Text = currentRooms.ToString();
            lblRooms.Text = roomsAmount.ToString();
            dgvRooms.DataSource = currentRoomsSrc;
        }

        private void lstTipo_click(object sender, EventArgs e)
        {
            if (lstTipo.SelectedIndex != selectedRoom)
            {
                if (!locked)
                {
                    selectedRoom = lstTipo.SelectedIndex;
                    object valueMember = lstTipo.SelectedValue;
                    Directory.Delete(tmpF, true);
                    Directory.CreateDirectory(tmpF);
                    formData((int)valueMember);
                }
                else
                {
                    MessageBox.Show("Complete el formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lstTipo.SelectedIndex = selectedRoom;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (locked)
            {
                MessageBox.Show("No puede crear otra categoría mientras se está creando una", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtRoom.Text.Length > 0)
            {
                if (!habitacionesExistentes.Contains(txtRoom.Text))
                {
                    currentSrc.Rows.Add("0", txtRoom.Text);
                    lstTipo.SelectedIndex = (currentSrc.Rows.Count - 1);
                    selectedRoom = (currentSrc.Rows.Count - 1);
                    lstConfig(currentSrc);

                    imgHabitacion.Image = null;
                    imgs = null;
                    currentImg = 0;
                    txtNombre.Text = txtRoom.Text;
                    txtRoom.Text = "";
                    txtDesc.Text = "";
                    numPrecio.Value = 0;
                    numOcupacion.Value = 0;
                    numDimensiones.Value = 0;
                    txtAlta.Text = DateTime.Now.ToString();
                    displayOption(pnlImage, pnlTable);
                    cbDisplay.SelectedItem = "Imagenes";
                    locked = true;
                }
            }
        }

        private int currentImg = 0;
        private void select2_Click(object sender, EventArgs e)
        {
            int i = currentImg + 1;
            if (imgs != null && i < imgs.Length)
            {
                currentImg = i;
                imgHabitacion.Image = new Bitmap(imgs[i]);
            }
        }

        private void select1_Click(object sender, EventArgs e)
        {
            int i = currentImg - 1;
            if (imgs != null && i > -1)
            {
                currentImg = i;
                imgHabitacion.Image = new Bitmap(imgs[i]);
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
                if (dialog.FileNames.Length < 6)
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
                        imgHabitacion.Image = new Bitmap(imgs[0]);
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

                txtDesc.Text = txt;
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (
                txtNombre.Text.Length == 0 || txtDesc.Text.Length == 0 || numPrecio.Value == 0 || imgs == null ||
                numDimensiones.Value == 0 || numOcupacion.Value == 0
               )
            {
                MessageBox.Show("Complete el formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string msg = !locked ? "Se cambiarán los datos de la categoría de habitación para todos los hoteles, si lo que desea es presentar otra información para sus habitaciones. Lo ideal es dar de baja todas las habitaciones de la categoría actual y crear una nueva categoría con los datos que desee." : "Se creará una nueva categoría de habitación";
            DialogResult res = MessageBox.Show(msg, "¿Está seguro de ejecutar esta acción?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
            if (res == DialogResult.Yes)
            {
                imgHabitacion.Image.Dispose();
                try
                {
                    habitacionesBLL habitacion = new habitacionesBLL();
                    habitacion.nombre = txtNombre.Text;
                    habitacion.descripcion = txtDesc.Text;
                    habitacion.precio = numPrecio.Value;
                    habitacion.imagenes = imgs;
                    habitacion.ocupacion = (int)numOcupacion.Value;
                    habitacion.dimensiones = numDimensiones.Value;
                    habitacion.fAlta = txtAlta.Text;

                    if (locked)
                    {
                        habitacion.newRoom(idHotel);
                        listComponents();
                        formData((int)lstTipo.SelectedValue);
                        locked = false;
                        MessageBox.Show("Se añadió una nueva habitación a la lista", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        habitacion.id = (int)lstTipo.SelectedValue;
                        habitacion.modifyRoom();
                        listComponents();
                        MessageBox.Show("Se ha modificado la habitación", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void cbDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (locked)
            {
                cbDisplay.SelectedItem = "Imagenes";
                return;
            }
            switch (cbDisplay.SelectedItem)
            {
                case "Imagenes":
                    displayOption(pnlImage, pnlTable);
                    break;
                case "Habitaciones":
                    displayOption(pnlTable, pnlImage);
                    break;
            }
            
        }

        private void displayOption(Control Dcontainer, Control Ucontainer)
        {
            Ucontainer.Visible = false;

            Dcontainer.Dock = DockStyle.Fill;
            Dcontainer.Visible = true;
        }

        List<object> idsRooms = new List<object>();
        private void btnRowState_Click(object sender, EventArgs e)
        {
            if (dgvRooms.SelectedRows.Count > 0)
            {
                DataGridViewSelectedRowCollection rows = dgvRooms.SelectedRows;

                foreach (DataGridViewRow row in rows)
                {
                    object value = row.Cells["fecha_baja"].Value;
                    row.Cells["fecha_baja"].Value = value == DBNull.Value ? (object)DateTime.Today : DBNull.Value;

                    if (idsRooms.Contains(row.Cells["id_habitacion"].Value)) {
                        idsRooms.Remove(row.Cells["id_habitacion"].Value);
                    } else {
                        idsRooms.Add(row.Cells["id_habitacion"].Value);
                    } 
                }
            }   
        }

        private int addRows = 0;
        private void btnAddRow_Click(object sender, EventArgs e)
        {

                addRows++;
                currentRoomsSrc.Rows.Add(0, DateTime.Now, DBNull.Value);
                dgvRooms.Refresh();
        }

        private void btnSaveRows_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Se guardará la configuración actual de las habitaciones", "¿Está seguro de ejecutar esta acción?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (res == DialogResult.Yes)
            {
                if (idsRooms.Count == 0 && addRows == 0)
                {
                    MessageBox.Show("No se han realizado modificaciones", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                try
                {
                    habitacionesBLL bll = new habitacionesBLL();
                    bll.updateRooms(idsRooms);
                    bll.insertRooms(addRows, idHotel, (int)lstTipo.SelectedValue);
                    idsRooms = new List<object>();
                    addRows = 0;

                    MessageBox.Show("El estado de las habitaciones han sido actualizadas", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);              
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /*
        private void btnState_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("De presionar \"Si\" la categoría de habitación ya no formará parte del hotel\nDe presionar \"No\" lo hará\n No se guardarán los cambios hasta que presione \"Guardar\"", "Estado de la categoría", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                txtBaja.Text = DateTime.Now.ToString();
            }
            else
            {
                txtBaja.Text = "";
            }
        }
        */
    }
}
