﻿namespace Login
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            Btnminimizar = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtuser = new TextBox();
            txtpass = new TextBox();
            btnlogin = new Button();
            label3 = new Label();
            Btncerrar = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Btnminimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Btncerrar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AllowDrop = true;
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(286, 440);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 81);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(263, 255);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            // 
            // Btnminimizar
            // 
            Btnminimizar.BackColor = Color.DimGray;
            Btnminimizar.Image = Properties.Resources.icons8_minimize_window_24;
            Btnminimizar.Location = new Point(827, 0);
            Btnminimizar.Margin = new Padding(3, 4, 3, 4);
            Btnminimizar.Name = "Btnminimizar";
            Btnminimizar.Size = new Size(24, 24);
            Btnminimizar.SizeMode = PictureBoxSizeMode.AutoSize;
            Btnminimizar.TabIndex = 9;
            Btnminimizar.TabStop = false;
            Btnminimizar.Click += Btnminimizar_Click_1;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Location = new Point(398, 125);
            label1.Name = "label1";
            label1.Size = new Size(418, 1);
            label1.TabIndex = 1;
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.Location = new Point(398, 245);
            label2.Name = "label2";
            label2.Size = new Size(418, 1);
            label2.TabIndex = 1;
            // 
            // txtuser
            // 
            txtuser.BackColor = Color.FromArgb(15, 15, 15);
            txtuser.BorderStyle = BorderStyle.None;
            txtuser.ForeColor = SystemColors.ScrollBar;
            txtuser.Location = new Point(398, 100);
            txtuser.Margin = new Padding(3, 4, 3, 4);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(418, 20);
            txtuser.TabIndex = 1;
            txtuser.Text = "USUARIO";
            txtuser.TextChanged += txtuser_TextChanged;
            txtuser.Enter += txtuser_Enter;
            txtuser.Leave += txtuser_Leave;
            // 
            // txtpass
            // 
            txtpass.BackColor = Color.FromArgb(15, 15, 15);
            txtpass.BorderStyle = BorderStyle.None;
            txtpass.ForeColor = SystemColors.ScrollBar;
            txtpass.Location = new Point(398, 220);
            txtpass.Margin = new Padding(3, 4, 3, 4);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(418, 20);
            txtpass.TabIndex = 2;
            txtpass.Text = "CONTRASEÑA";
            txtpass.Enter += txtpass_Enter;
            txtpass.Leave += txtpass_Leave;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.FromArgb(40, 40, 40);
            btnlogin.FlatStyle = FlatStyle.Flat;
            btnlogin.ForeColor = SystemColors.ButtonFace;
            btnlogin.Location = new Point(451, 283);
            btnlogin.Margin = new Padding(3, 4, 3, 4);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(315, 53);
            btnlogin.TabIndex = 0;
            btnlogin.Text = "INGRESAR";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.AppWorkspace;
            label3.Location = new Point(569, 12);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 3;
            label3.Text = "LOGIN";
            // 
            // Btncerrar
            // 
            Btncerrar.BackColor = Color.DimGray;
            Btncerrar.Image = Properties.Resources.icons8_close_window_24;
            Btncerrar.Location = new Point(862, 0);
            Btncerrar.Margin = new Padding(3, 4, 3, 4);
            Btncerrar.Name = "Btncerrar";
            Btncerrar.Size = new Size(26, 32);
            Btncerrar.TabIndex = 8;
            Btncerrar.TabStop = false;
            Btncerrar.Click += Btncerrar_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(891, 440);
            Controls.Add(Btnminimizar);
            Controls.Add(Btncerrar);
            Controls.Add(label3);
            Controls.Add(btnlogin);
            Controls.Add(txtpass);
            Controls.Add(txtuser);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Opacity = 0.93D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            MouseDown += Form1_MouseDown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Btnminimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Btncerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox txtuser;
        private TextBox txtpass;
        private Button btnlogin;
        private Label label3;
        private PictureBox Btnminimizar;
        private PictureBox Btncerrar;
        private PictureBox pictureBox1;
    }
}
