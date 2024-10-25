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
    public partial class Facturas : Form
    {
        public Facturas()
        {
            InitializeComponent();
        }

        private void btnGenerarFactura_Click(object sender, EventArgs e)
        {
            string IdOrden = txtIdOrden.Text;
            string DescripcionFactura = txtDescripcionFactura.Text;


            string mensaje = ConeccionDB.InsertFacturas(Convert.ToInt32(IdOrden), DescripcionFactura);
            MessageBox.Show(mensaje);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }
    }
}
