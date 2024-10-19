using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessDB;

namespace Login
{
    public partial class Cliente : Form
    {
        public Cliente()
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
            string NIT = txtNIT.Text;
            if ((nombre != "") && (NIT != ""))
            {
                string mensaje = ConeccionDB.InsertClientes(nombre, NIT);
                MessageBox.Show(mensaje);
                txtNombre.Text = "";
                txtNIT.Text = "";
            }
            else
            {
                MessageBox.Show("No puedes ingresar valores vacios");
            }
        }

        private void Cliente_Load(object sender, EventArgs e)
        {

        }
    }
}
