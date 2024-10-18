namespace Login
{
    partial class Ordenes
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
            txtNombreCliente = new TextBox();
            txtNombrePlato = new TextBox();
            txtMesa = new TextBox();
            nombrecliente = new Label();
            label2 = new Label();
            label3 = new Label();
            btnGenerarOrden = new Button();
            btnRegresaraMenu = new Button();
            btnAgregarOtroPlato = new Button();
            btnEliminarPlato = new Button();
            btnAgregarPlato = new Button();
            txtNItCliente = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(28, 43);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(125, 27);
            txtNombreCliente.TabIndex = 0;
            txtNombreCliente.TextChanged += txtNombreCliente_TextChanged;
            // 
            // txtNombrePlato
            // 
            txtNombrePlato.Location = new Point(28, 132);
            txtNombrePlato.Name = "txtNombrePlato";
            txtNombrePlato.Size = new Size(125, 27);
            txtNombrePlato.TabIndex = 1;
            // 
            // txtMesa
            // 
            txtMesa.Location = new Point(28, 224);
            txtMesa.Name = "txtMesa";
            txtMesa.Size = new Size(125, 27);
            txtMesa.TabIndex = 2;
            // 
            // nombrecliente
            // 
            nombrecliente.AutoSize = true;
            nombrecliente.Location = new Point(28, 9);
            nombrecliente.Name = "nombrecliente";
            nombrecliente.Size = new Size(141, 20);
            nombrecliente.TabIndex = 4;
            nombrecliente.Text = "Nombre Del Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 102);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 5;
            label2.Text = "Nombre Del Plato";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 188);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 6;
            label3.Text = "Mesa";
            // 
            // btnGenerarOrden
            // 
            btnGenerarOrden.Location = new Point(49, 302);
            btnGenerarOrden.Name = "btnGenerarOrden";
            btnGenerarOrden.Size = new Size(165, 29);
            btnGenerarOrden.TabIndex = 7;
            btnGenerarOrden.Text = "GenerarOrden";
            btnGenerarOrden.UseVisualStyleBackColor = true;
            btnGenerarOrden.Click += btnGenerarOrden_Click;
            // 
            // btnRegresaraMenu
            // 
            btnRegresaraMenu.Location = new Point(666, 396);
            btnRegresaraMenu.Name = "btnRegresaraMenu";
            btnRegresaraMenu.Size = new Size(94, 29);
            btnRegresaraMenu.TabIndex = 8;
            btnRegresaraMenu.Text = "Regresar";
            btnRegresaraMenu.UseVisualStyleBackColor = true;
            btnRegresaraMenu.Click += btnRegresaraMenu_Click;
            // 
            // btnAgregarOtroPlato
            // 
            btnAgregarOtroPlato.Location = new Point(370, 102);
            btnAgregarOtroPlato.Name = "btnAgregarOtroPlato";
            btnAgregarOtroPlato.Size = new Size(196, 29);
            btnAgregarOtroPlato.TabIndex = 9;
            btnAgregarOtroPlato.Text = "Agregar Otro Plato";
            btnAgregarOtroPlato.UseVisualStyleBackColor = true;
            // 
            // btnEliminarPlato
            // 
            btnEliminarPlato.Location = new Point(370, 155);
            btnEliminarPlato.Name = "btnEliminarPlato";
            btnEliminarPlato.Size = new Size(141, 29);
            btnEliminarPlato.TabIndex = 10;
            btnEliminarPlato.Text = "Eliminar Plato";
            btnEliminarPlato.UseVisualStyleBackColor = true;
            // 
            // btnAgregarPlato
            // 
            btnAgregarPlato.Location = new Point(370, 43);
            btnAgregarPlato.Name = "btnAgregarPlato";
            btnAgregarPlato.Size = new Size(141, 29);
            btnAgregarPlato.TabIndex = 11;
            btnAgregarPlato.Text = "Agregar Plato";
            btnAgregarPlato.UseVisualStyleBackColor = true;
            // 
            // txtNItCliente
            // 
            txtNItCliente.Location = new Point(175, 45);
            txtNItCliente.Name = "txtNItCliente";
            txtNItCliente.Size = new Size(125, 27);
            txtNItCliente.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(175, 9);
            label1.Name = "label1";
            label1.Size = new Size(32, 20);
            label1.TabIndex = 13;
            label1.Text = "NIT";
            // 
            // Ordenes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtNItCliente);
            Controls.Add(btnAgregarPlato);
            Controls.Add(btnEliminarPlato);
            Controls.Add(btnAgregarOtroPlato);
            Controls.Add(btnRegresaraMenu);
            Controls.Add(btnGenerarOrden);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(nombrecliente);
            Controls.Add(txtMesa);
            Controls.Add(txtNombrePlato);
            Controls.Add(txtNombreCliente);
            Name = "Ordenes";
            Text = "Ordenes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreCliente;
        private TextBox txtNombrePlato;
        private TextBox txtMesa;
        private Label nombrecliente;
        private Label label2;
        private Label label3;
        private Button btnGenerarOrden;
        private Button btnRegresaraMenu;
        private Button btnAgregarOtroPlato;
        private Button btnEliminarPlato;
        private Button btnAgregarPlato;
        private TextBox txtNItCliente;
        private Label label1;
    }
}