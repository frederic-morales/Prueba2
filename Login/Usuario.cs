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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Login
{
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Usuario_Load(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text; 
            string name = txtName.Text;

            if ((userName != "") && (password != "") && (name != ""))
            {
                string mensaje = ConeccionDB.InsertUsuarios(userName, password, name);
                MessageBox.Show(mensaje);
                txtUserName.Text = "";
                txtPassword.Text = "";
                txtName.Text = "";
            }
            else
            {
                MessageBox.Show("No puedes ingresar valores vacios");
            }
        }
    }
}
