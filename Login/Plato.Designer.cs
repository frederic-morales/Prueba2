namespace Login
{
    partial class Plato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Plato));
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            NombrePlato = new Label();
            label1 = new Label();
            btnAgregar = new Button();
            btnRegresar = new Button();
            label2 = new Label();
            txtDetallePlato = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(209, 91);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(327, 27);
            txtNombre.TabIndex = 0;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(209, 156);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(327, 27);
            txtPrecio.TabIndex = 1;
            // 
            // NombrePlato
            // 
            NombrePlato.AutoSize = true;
            NombrePlato.Location = new Point(71, 101);
            NombrePlato.Name = "NombrePlato";
            NombrePlato.Size = new Size(127, 20);
            NombrePlato.TabIndex = 2;
            NombrePlato.Text = "Nombre del Plato";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 167);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 3;
            label1.Text = "Precio";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(263, 313);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 39);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(421, 313);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(94, 39);
            btnRegresar.TabIndex = 5;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 240);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 7;
            label2.Text = "Detalles del plato";
            // 
            // txtDetallePlato
            // 
            txtDetallePlato.Location = new Point(209, 229);
            txtDetallePlato.Name = "txtDetallePlato";
            txtDetallePlato.Size = new Size(327, 27);
            txtDetallePlato.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(221, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_close_window_241;
            pictureBox2.Location = new Point(255, -1);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Chocolate;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(571, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(286, 440);
            panel1.TabIndex = 10;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.logo_debug_blanco_removebg_preview1;
            pictureBox3.Location = new Point(32, 101);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(221, 196);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            pictureBox3.MouseDown += pictureBox3_MouseDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Location = new Point(209, -1);
            label3.Name = "label3";
            label3.Size = new Size(136, 20);
            label3.TabIndex = 11;
            label3.Text = "Gestión de Platillos";
            // 
            // Plato
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(857, 440);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(txtDetallePlato);
            Controls.Add(btnRegresar);
            Controls.Add(btnAgregar);
            Controls.Add(label1);
            Controls.Add(NombrePlato);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Plato";
            Text = "Plato";
            Load += Plato_Load;
            MouseDown += Plato_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtPrecio;
        private Label NombrePlato;
        private Label label1;
        private Button btnAgregar;
        private Button btnRegresar;
        private Label label2;
        private TextBox txtDetallePlato;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private PictureBox pictureBox3;
        private Label label3;
    }
}