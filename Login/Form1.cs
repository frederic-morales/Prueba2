using System.Runtime.InteropServices;
//using BusinessEntity; //14c2d39963dd6983b19bb9cdbe5a17d2d076984d
using DataAccessDB;


namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //ConeccionDB.InsertUsuarios("Frederic78", "Contrase�aFrederic", "Ariel");
            //ConeccionDB.InsertPlatos("Hamburguesa de carne", "Hamburguesa de carne 20 gramos y papas con queso", 32.50);
            //ConeccionDB.InsertClientes("Frederic_Cliente", 307521982);
            InitializeComponent();
        }
        
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "USUARIO")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.LightGray;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "USUARIO";
                txtuser.ForeColor = Color.LightGray;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "CONTRASE�A")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "CONTRASE�A";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Btncerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btnminimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

            string usuario = txtuser.Text;
            string contrase�a = txtpass.Text;
            bool aceptarUsuario = ConeccionDB.ValidarUsuario(usuario, contrase�a);

            if (aceptarUsuario)
            {
                {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
                }
            }
            else
            {
               MessageBox.Show("Usuario o contras�a incorrectos");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
