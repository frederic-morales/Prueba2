﻿namespace Login
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
            SuspendLayout();
            // 
            // buttonCLientes
            // 
            buttonCLientes.Location = new Point(94, 92);
            buttonCLientes.Name = "buttonCLientes";
            buttonCLientes.Size = new Size(94, 29);
            buttonCLientes.TabIndex = 0;
            buttonCLientes.Text = "Clientes";
            buttonCLientes.UseVisualStyleBackColor = true;
            buttonCLientes.Click += buttonCLientes_Click;
            // 
            // buttonPlatos
            // 
            buttonPlatos.Location = new Point(94, 168);
            buttonPlatos.Name = "buttonPlatos";
            buttonPlatos.Size = new Size(94, 29);
            buttonPlatos.TabIndex = 1;
            buttonPlatos.Text = "Platos";
            buttonPlatos.UseVisualStyleBackColor = true;
            buttonPlatos.Click += buttonPlatos_Click;
            // 
            // buttonUsuario
            // 
            buttonUsuario.Location = new Point(94, 259);
            buttonUsuario.Name = "buttonUsuario";
            buttonUsuario.Size = new Size(94, 29);
            buttonUsuario.TabIndex = 2;
            buttonUsuario.Text = "Usuario";
            buttonUsuario.UseVisualStyleBackColor = true;
            buttonUsuario.Click += buttonUsuario_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonUsuario);
            Controls.Add(buttonPlatos);
            Controls.Add(buttonCLientes);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonCLientes;
        private Button buttonPlatos;
        private Button buttonUsuario;
    }
}