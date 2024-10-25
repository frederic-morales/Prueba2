namespace Login
{
    partial class Cliente
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
            label1 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            txtNIT = new TextBox();
            btnRegresar = new Button();
            btnAgregar = new Button();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 40);
            label1.Name = "label1";
            label1.Size = new Size(72, 23);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(38, 102);
            label2.Name = "label2";
            label2.Size = new Size(31, 23);
            label2.TabIndex = 1;
            label2.Text = "Nit";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(38, 71);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(456, 23);
            txtNombre.TabIndex = 2;
            // 
            // txtNIT
            // 
            txtNIT.Location = new Point(38, 127);
            txtNIT.Margin = new Padding(3, 2, 3, 2);
            txtNIT.Name = "txtNIT";
            txtNIT.Size = new Size(190, 23);
            txtNIT.TabIndex = 3;
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.Red;
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegresar.ForeColor = SystemColors.ActiveCaptionText;
            btnRegresar.ImageAlign = ContentAlignment.BottomLeft;
            btnRegresar.Location = new Point(289, 191);
            btnRegresar.Margin = new Padding(3, 2, 3, 2);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(149, 32);
            btnRegresar.TabIndex = 4;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(0, 192, 0);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(81, 191);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(156, 32);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Chocolate;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(550, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(150, 261);
            panel1.TabIndex = 6;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_minimize_window_245;
            pictureBox2.Location = new Point(93, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.logo_debug_blanco_removebg_preview5;
            pictureBox3.Location = new Point(3, 51);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(147, 172);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            pictureBox3.MouseDown += pictureBox3_MouseDown;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_close_window_245;
            pictureBox1.Location = new Point(115, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(206, 9);
            label3.Name = "label3";
            label3.Size = new Size(162, 23);
            label3.TabIndex = 7;
            label3.Text = "Control De Clientes";
            label3.TextAlign = ContentAlignment.TopCenter;
            label3.Click += label3_Click;
            // 
            // Cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(700, 261);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(btnAgregar);
            Controls.Add(btnRegresar);
            Controls.Add(txtNIT);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Cliente";
            Text = "Cliente";
            Load += Cliente_Load;
            MouseDown += Cliente_MouseDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private TextBox txtNIT;
        private Button btnRegresar;
        private Button btnAgregar;
        private Panel panel1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label3;
    }
}