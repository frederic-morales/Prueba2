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
    }
}
