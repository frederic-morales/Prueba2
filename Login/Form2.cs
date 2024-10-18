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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonCLientes_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Show();
            this.Hide();
        }

        private void buttonUsuario_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Show();
            this.Hide();
        }

        private void buttonPlatos_Click(object sender, EventArgs e)
        {
            Plato plato = new Plato();
            plato.Show();
            this.Hide();
        }
    }
}
