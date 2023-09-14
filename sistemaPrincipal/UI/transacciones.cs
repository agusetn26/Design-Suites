using System;
using System.Windows.Forms;
using System.Collections.Generic;

using sistemaPrincipal.DAL;

namespace sistemaPrincipal
{
    public partial class transacciones : Form
    {
        private baseForm currentForm;
        private transaccionesDAL dal;
        public transacciones(baseForm form)
        {
            InitializeComponent();
            currentForm = form;
            dal = new transaccionesDAL();
            tableFill();
        }

        private void transacciones_Load(object sender, EventArgs e)
        {
            contenedorTrans.ClearSelection();
        }

        private void tableFill()
        {
            contenedorTrans.DataSource = dal.select().Tables[0];
        }

        private void back(object sender, EventArgs e)
        {
            currentForm.changeForm(new menu(currentForm));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection filas =  contenedorTrans.SelectedRows;
            if(filas.Count == 0)
            {
                MessageBox.Show("Seleccione transacciones pendientes para concretar la transferencia", "Seleccionar fila", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            foreach (DataGridViewRow fila in filas)
            {

                if (fila.Cells["estado"].Value.ToString() == "pendiente")
                {

                    string cantidad = fila.Cells["cantidad"].Value.ToString();
                    string id_suministro = fila.Cells["id_suministro"].Value.ToString();
                    string id_transaccion = fila.Cells["id_transaccion"].Value.ToString();

                    if(!dal.actualizarListado(id_suministro, cantidad, id_transaccion))
                    {
                        MessageBox.Show("Hubo un error al actualizar el listado, comunicarse con soporte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                else
                {
                    MessageBox.Show("Seleccione transacciones pendientes para concretar la transferencia", "Seleccionar fila", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            MessageBox.Show("Se han actualizado las transacciones", "Success", MessageBoxButtons.OK);
            this.tableFill();
        }
    }
}
