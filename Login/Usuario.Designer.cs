namespace Login
{
    partial class Usuario
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
            txtUserName = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnRegresar = new Button();
            btnAgregarUsuario = new Button();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(50, 70);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(179, 27);
            txtUserName.TabIndex = 0;
            txtUserName.TextChanged += txtUserName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 37);
            label1.Name = "label1";
            label1.Size = new Size(141, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre De Usuario";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(50, 171);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(179, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(50, 276);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(179, 27);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 137);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 4;
            label2.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 238);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 5;
            label3.Text = "Nombre";
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(674, 391);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(94, 29);
            btnRegresar.TabIndex = 6;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnAgregarUsuario
            // 
            btnAgregarUsuario.Location = new Point(513, 203);
            btnAgregarUsuario.Name = "btnAgregarUsuario";
            btnAgregarUsuario.Size = new Size(94, 29);
            btnAgregarUsuario.TabIndex = 7;
            btnAgregarUsuario.Text = "Agregar";
            btnAgregarUsuario.UseVisualStyleBackColor = true;
            // 
            // Usuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAgregarUsuario);
            Controls.Add(btnRegresar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(txtUserName);
            Name = "Usuario";
            Text = "Usuario";
            Load += Usuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserName;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Button btnRegresar;
        private Button btnAgregarUsuario;
    }
}