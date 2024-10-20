﻿using DataAccessDB;
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
            string cantidad = txtCantidad.Text;
            List<string> datosPlato = ConeccionDB.obtenerPlato(nombrePlato);

            if (datosPlato.Count() == 3)
            {
                dataGridViewPlatos.Rows.Add(datosPlato[0], datosPlato[1], datosPlato[2], cantidad);
                txtNombrePlato.Text = "";
                txtCantidad.Text = "";
                //MessageBox.Show("Agrendo plato");
            }
            else
            {
                MessageBox.Show("No se encontro el plato");
                txtNombrePlato.Text = "";
                txtCantidad.Text = "";
            }

            //MessageBox.Show($"Index: {datosPlato.Count()}, {datosPlato[0]} {datosPlato[1]}, {datosPlato[2]}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridViewPlatos.SelectedRows.Count > 0)
            {
                int indiceFila = dataGridViewPlatos.SelectedRows[0].Index;
                dataGridViewPlatos.Rows.RemoveAt(indiceFila);
                MessageBox.Show("¡Elemento eliminado correctamente!");
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para eliminar.");
            }
        }
        private void btnGenerarOrden_Click(object sender, EventArgs e)
        {
            string NitIngresado = txtNitCliente.Text;
            int IdCliente = ConeccionDB.obtenerIdCliente(Convert.ToInt32(NitIngresado));

            if (IdCliente != 0)
            {
                string mesa = txtMesa.Text;
                string Detalle_Orden = txtDetalleOrden.Text;
                DateTime Fecha = DateTime.Now;  
                int IdOrden = ConeccionDB.InsertOrden(IdCliente, Convert.ToInt32(mesa), Detalle_Orden, Fecha.Date);
                MessageBox.Show("Orden Generada con exito");
                MessageBox.Show($"{IdOrden}");
            }
            else
            {
                MessageBox.Show("No existe cliente con ese NIT");
            }
        }

    }
}
