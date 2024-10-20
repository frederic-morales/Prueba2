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
            btnAgregarPlato = new Button();
            txtNItCliente = new TextBox();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            dataGridViewPlatos = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Detalle = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlatos).BeginInit();
            SuspendLayout();
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(23, 469);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(181, 27);
            txtNombreCliente.TabIndex = 0;
            txtNombreCliente.TextChanged += txtNombreCliente_TextChanged;
            // 
            // txtNombrePlato
            // 
            txtNombrePlato.Location = new Point(28, 104);
            txtNombrePlato.Name = "txtNombrePlato";
            txtNombrePlato.Size = new Size(125, 27);
            txtNombrePlato.TabIndex = 1;
            // 
            // txtMesa
            // 
            txtMesa.Location = new Point(408, 470);
            txtMesa.Name = "txtMesa";
            txtMesa.Size = new Size(125, 27);
            txtMesa.TabIndex = 2;
            // 
            // nombrecliente
            // 
            nombrecliente.AutoSize = true;
            nombrecliente.Location = new Point(23, 435);
            nombrecliente.Name = "nombrecliente";
            nombrecliente.Size = new Size(141, 20);
            nombrecliente.TabIndex = 4;
            nombrecliente.Text = "Nombre Del Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 74);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 5;
            label2.Text = "Nombre Del Plato";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(408, 433);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 6;
            label3.Text = "Mesa";
            label3.Click += label3_Click;
            // 
            // btnGenerarOrden
            // 
            btnGenerarOrden.Location = new Point(566, 468);
            btnGenerarOrden.Name = "btnGenerarOrden";
            btnGenerarOrden.Size = new Size(165, 29);
            btnGenerarOrden.TabIndex = 7;
            btnGenerarOrden.Text = "Finzalizar Orden";
            btnGenerarOrden.UseVisualStyleBackColor = true;
            btnGenerarOrden.Click += btnGenerarOrden_Click;
            // 
            // btnRegresaraMenu
            // 
            btnRegresaraMenu.Location = new Point(771, 471);
            btnRegresaraMenu.Name = "btnRegresaraMenu";
            btnRegresaraMenu.Size = new Size(94, 29);
            btnRegresaraMenu.TabIndex = 8;
            btnRegresaraMenu.Text = "Regresar";
            btnRegresaraMenu.UseVisualStyleBackColor = true;
            btnRegresaraMenu.Click += btnRegresaraMenu_Click;
            // 
            // btnAgregarPlato
            // 
            btnAgregarPlato.Location = new Point(187, 102);
            btnAgregarPlato.Name = "btnAgregarPlato";
            btnAgregarPlato.Size = new Size(141, 29);
            btnAgregarPlato.TabIndex = 11;
            btnAgregarPlato.Text = "Agregar Plato";
            btnAgregarPlato.UseVisualStyleBackColor = true;
            btnAgregarPlato.Click += btnAgregarPlato_Click;
            // 
            // txtNItCliente
            // 
            txtNItCliente.Location = new Point(227, 471);
            txtNItCliente.Name = "txtNItCliente";
            txtNItCliente.Size = new Size(144, 27);
            txtNItCliente.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(227, 435);
            label1.Name = "label1";
            label1.Size = new Size(32, 20);
            label1.TabIndex = 13;
            label1.Text = "NIT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 29);
            label4.Name = "label4";
            label4.Size = new Size(196, 20);
            label4.TabIndex = 14;
            label4.Text = "Ingrese los platos a la orden";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 154);
            label5.Name = "label5";
            label5.Size = new Size(180, 20);
            label5.TabIndex = 15;
            label5.Text = "Platos listos para ordenar:";
            // 
            // dataGridViewPlatos
            // 
            dataGridViewPlatos.AllowUserToAddRows = false;
            dataGridViewPlatos.AllowUserToDeleteRows = false;
            dataGridViewPlatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPlatos.Columns.AddRange(new DataGridViewColumn[] { Nombre, Detalle, Precio });
            dataGridViewPlatos.Location = new Point(28, 189);
            dataGridViewPlatos.Name = "dataGridViewPlatos";
            dataGridViewPlatos.ReadOnly = true;
            dataGridViewPlatos.RowHeadersWidth = 51;
            dataGridViewPlatos.Size = new Size(551, 213);
            dataGridViewPlatos.TabIndex = 16;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 125;
            // 
            // Detalle
            // 
            Detalle.HeaderText = "Detalle";
            Detalle.MinimumWidth = 6;
            Detalle.Name = "Detalle";
            Detalle.ReadOnly = true;
            Detalle.Width = 125;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            Precio.Width = 125;
            // 
            // button1
            // 
            button1.Location = new Point(611, 274);
            button1.Name = "button1";
            button1.Size = new Size(213, 47);
            button1.TabIndex = 17;
            button1.Text = "Eliminar plato de la orden";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Ordenes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 534);
            Controls.Add(button1);
            Controls.Add(dataGridViewPlatos);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(txtNItCliente);
            Controls.Add(btnAgregarPlato);
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
            Load += Ordenes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlatos).EndInit();
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
        private Button btnAgregarPlato;
        private TextBox txtNItCliente;
        private Label label1;
        private Label label4;
        private Label label5;
        private DataGridView dataGridViewPlatos;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Detalle;
        private DataGridViewTextBoxColumn Precio;
        private Button button1;
    }
}