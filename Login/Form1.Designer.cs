namespace Login
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
            panel1 = new Panel();
            btnminimizar = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtuser = new TextBox();
            txtpass = new TextBox();
            btnlogin = new Button();
            label3 = new Label();
            linkpass = new LinkLabel();
            btncerrar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btnminimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btncerrar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AllowDrop = true;
            panel1.BackColor = Color.RoyalBlue;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 330);
            panel1.TabIndex = 0;
            // 
            // btnminimizar
            // 
            btnminimizar.BackColor = Color.DimGray;
            btnminimizar.Image = Properties.Resources.icons8_minimize_window_24;
            btnminimizar.Location = new Point(724, 0);
            btnminimizar.Name = "btnminimizar";
            btnminimizar.Size = new Size(24, 24);
            btnminimizar.SizeMode = PictureBoxSizeMode.AutoSize;
            btnminimizar.TabIndex = 9;
            btnminimizar.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Location = new Point(348, 94);
            label1.Name = "label1";
            label1.Size = new Size(366, 1);
            label1.TabIndex = 1;
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.Location = new Point(348, 184);
            label2.Name = "label2";
            label2.Size = new Size(366, 1);
            label2.TabIndex = 1;
            // 
            // txtuser
            // 
            txtuser.BackColor = Color.FromArgb(15, 15, 15);
            txtuser.BorderStyle = BorderStyle.None;
            txtuser.ForeColor = SystemColors.ScrollBar;
            txtuser.Location = new Point(348, 75);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(366, 16);
            txtuser.TabIndex = 2;
            txtuser.Text = "USUARIO";
            txtuser.Enter += txtuser_Enter;
            txtuser.Leave += txtuser_Leave;
            // 
            // txtpass
            // 
            txtpass.BackColor = Color.FromArgb(15, 15, 15);
            txtpass.BorderStyle = BorderStyle.None;
            txtpass.ForeColor = SystemColors.ScrollBar;
            txtpass.Location = new Point(348, 165);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(366, 16);
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
            btnlogin.Location = new Point(395, 212);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(276, 40);
            btnlogin.TabIndex = 3;
            btnlogin.Text = "INGRESAR";
            btnlogin.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.AppWorkspace;
            label3.Location = new Point(498, 9);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 4;
            label3.Text = "LOGIN";
            // 
            // linkpass
            // 
            linkpass.ActiveLinkColor = Color.Blue;
            linkpass.AutoSize = true;
            linkpass.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkpass.LinkColor = Color.FromArgb(192, 192, 255);
            linkpass.Location = new Point(442, 274);
            linkpass.Name = "linkpass";
            linkpass.Size = new Size(199, 17);
            linkpass.TabIndex = 5;
            linkpass.TabStop = true;
            linkpass.Text = "¿Ha olvidado su contraseña?";
            // 
            // btncerrar
            // 
            btncerrar.BackColor = Color.DimGray;
            btncerrar.Image = Properties.Resources.icons8_close_window_24;
            btncerrar.Location = new Point(754, 0);
            btncerrar.Name = "btncerrar";
            btncerrar.Size = new Size(23, 24);
            btncerrar.TabIndex = 8;
            btncerrar.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(780, 330);
            Controls.Add(btnminimizar);
            Controls.Add(btncerrar);
            Controls.Add(linkpass);
            Controls.Add(label3);
            Controls.Add(btnlogin);
            Controls.Add(txtpass);
            Controls.Add(txtuser);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Opacity = 0.93D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)btnminimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btncerrar).EndInit();
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
        private LinkLabel linkpass;
        private PictureBox btnminimizar;
        private PictureBox btncerrar;
    }
}
