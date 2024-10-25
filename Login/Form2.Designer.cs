namespace Login
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonCLientes = new Button();
            buttonPlatos = new Button();
            buttonUsuario = new Button();
            btnOrdenes = new Button();
            panel1 = new Panel();
            Btnminimizar = new PictureBox();
            pictureBox3 = new PictureBox();
            BtnCerrar = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            buttonFacturas = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Btnminimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnCerrar).BeginInit();
            SuspendLayout();
            // 
            // buttonCLientes
            // 
            buttonCLientes.Location = new Point(222, 108);
            buttonCLientes.Name = "buttonCLientes";
            buttonCLientes.Size = new Size(110, 44);
            buttonCLientes.TabIndex = 0;
            buttonCLientes.Text = "Clientes";
            buttonCLientes.UseVisualStyleBackColor = true;
            buttonCLientes.Click += buttonCLientes_Click;
            // 
            // buttonPlatos
            // 
            buttonPlatos.Location = new Point(66, 233);
            buttonPlatos.Name = "buttonPlatos";
            buttonPlatos.Size = new Size(110, 52);
            buttonPlatos.TabIndex = 1;
            buttonPlatos.Text = "Platos";
            buttonPlatos.UseVisualStyleBackColor = true;
            buttonPlatos.Click += buttonPlatos_Click;
            // 
            // buttonUsuario
            // 
            buttonUsuario.Location = new Point(222, 233);
            buttonUsuario.Name = "buttonUsuario";
            buttonUsuario.Size = new Size(104, 52);
            buttonUsuario.TabIndex = 2;
            buttonUsuario.Text = "Usuario";
            buttonUsuario.UseVisualStyleBackColor = true;
            buttonUsuario.Click += buttonUsuario_Click;
            // 
            // btnOrdenes
            // 
            btnOrdenes.Location = new Point(66, 108);
            btnOrdenes.Name = "btnOrdenes";
            btnOrdenes.Size = new Size(104, 44);
            btnOrdenes.TabIndex = 3;
            btnOrdenes.Text = "Ordenes";
            btnOrdenes.UseVisualStyleBackColor = true;
            btnOrdenes.Click += btnOrdenes_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Chocolate;
            panel1.Controls.Add(Btnminimizar);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(BtnCerrar);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(530, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(286, 388);
            panel1.TabIndex = 4;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // Btnminimizar
            // 
            Btnminimizar.Image = Properties.Resources.icons8_minimize_window_242;
            Btnminimizar.Location = new Point(221, 4);
            Btnminimizar.Margin = new Padding(3, 4, 3, 4);
            Btnminimizar.Name = "Btnminimizar";
            Btnminimizar.Size = new Size(24, 24);
            Btnminimizar.SizeMode = PictureBoxSizeMode.AutoSize;
            Btnminimizar.TabIndex = 8;
            Btnminimizar.TabStop = false;
            Btnminimizar.Click += Btnminimizar_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.logo_debug_blanco_removebg_preview2;
            pictureBox3.Location = new Point(31, 56);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(241, 260);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            pictureBox3.MouseDown += pictureBox3_MouseDown;
            // 
            // BtnCerrar
            // 
            BtnCerrar.Image = Properties.Resources.icons8_close_window_242;
            BtnCerrar.Location = new Point(255, 4);
            BtnCerrar.Margin = new Padding(3, 4, 3, 4);
            BtnCerrar.Name = "BtnCerrar";
            BtnCerrar.Size = new Size(24, 24);
            BtnCerrar.SizeMode = PictureBoxSizeMode.AutoSize;
            BtnCerrar.TabIndex = 6;
            BtnCerrar.TabStop = false;
            BtnCerrar.Click += BtnCerrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 4);
            label1.Name = "label1";
            label1.Size = new Size(361, 20);
            label1.TabIndex = 5;
            label1.Text = "¡Bienvenidos a Sistema De Gestion De Pedidos (SGP)!";
            // 
            // button1
            // 
            button1.Location = new Point(372, 233);
            button1.Name = "button1";
            button1.Size = new Size(110, 52);
            button1.TabIndex = 6;
            button1.Text = "Reportes";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonFacturas
            // 
            buttonFacturas.Location = new Point(372, 108);
            buttonFacturas.Name = "buttonFacturas";
            buttonFacturas.Size = new Size(110, 44);
            buttonFacturas.TabIndex = 7;
            buttonFacturas.Text = "Facturas";
            buttonFacturas.UseVisualStyleBackColor = true;
            buttonFacturas.Click += buttonFacturas_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(816, 388);
            Controls.Add(buttonFacturas);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(btnOrdenes);
            Controls.Add(buttonUsuario);
            Controls.Add(buttonPlatos);
            Controls.Add(buttonCLientes);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Text = "Form2";
            MouseDown += Form2_MouseDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Btnminimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnCerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCLientes;
        private Button buttonPlatos;
        private Button buttonUsuario;
        private Button btnOrdenes;
        private Panel panel1;
        private PictureBox pictureBox3;

        private PictureBox BtnCerrar;
        private Label label1;
        private PictureBox Btnminimizar;
        private Button button1;
        private Button buttonFacturas;
    }
}