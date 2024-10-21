using DataAccessDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Ordenes : Form
    {
        public Ordenes()
        {
            InitializeComponent();
        }

        private void btnRegresaraMenu_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void txtNombreCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerarOrden_Click(object sender, EventArgs e)
        {
            Detallles_Orden detallles_Orden = new Detallles_Orden();
            detallles_Orden.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Ordenes_Load(object sender, EventArgs e)
        {

        }
        private void InicializarDataGridView()
        {
            // Configurar DataGridView
            //dataGridViewPlatos.DataSource = ordenPlatos;
            dataGridViewPlatos.AutoGenerateColumns = true;
        }

        private void btnAgregarPlato_Click(object sender, EventArgs e)
        {
            string nombrePlato = txtNombrePlato.Text;
            List<string> datosPlato = ConeccionDB.obtenerPlato(nombrePlato);

            if (datosPlato.Count() == 3)
            {
                dataGridViewPlatos.Rows.Add(datosPlato[0], datosPlato[1], datosPlato[2]);
                txtNombrePlato.Text = "";
                //MessageBox.Show("Agrendo plato");
            }
            else
            {
                MessageBox.Show("No se encontro el plato");
                txtNombrePlato.Text = "";
            }

            //MessageBox.Show($"Index: {datosPlato.Count()}, {datosPlato[0]} {datosPlato[1]}, {datosPlato[2]}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridViewPlatos.SelectedRows.Count > 0)
            {
                // Obtener el índice de la fila seleccionada
                int indiceFila = dataGridViewPlatos.SelectedRows[0].Index;
                // Refrescar el DataGridView para mostrar los cambios
                dataGridViewPlatos.Rows.RemoveAt(indiceFila);
                MessageBox.Show("¡Elemento eliminado correctamente!");
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para eliminar.");
            }
        }
    }
}
