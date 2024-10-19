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
    public partial class Plato : Form
    {
        public Plato()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string precio = txtPrecio.Text;
            string detallePlato = txtDetallePlato.Text;

            if ((nombre != "") && (precio != "") && (detallePlato != ""))
            {
                string mensaje = ConeccionDB.InsertPlatos(nombre, detallePlato, Convert.ToDouble(precio));
                MessageBox.Show(mensaje);
                txtNombre.Text = "";
                txtPrecio.Text = "";
                txtDetallePlato.Text = "";
            }
            else
            {
                MessageBox.Show("No puedes ingresar valores vacios");
            }
        }
    }
}
