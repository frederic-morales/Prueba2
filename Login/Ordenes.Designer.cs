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
            txtNitCliente = new TextBox();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            dataGridViewPlatos = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Detalle = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            button1 = new Button();
            txtCantidad = new TextBox();
            label6 = new Label();
            txtDetalleOrden = new TextBox();
            label7 = new Label();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlatos).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(24, 352);
            txtNombreCliente.Margin = new Padding(3, 2, 3, 2);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(184, 23);
            txtNombreCliente.TabIndex = 0;
            txtNombreCliente.TextChanged += txtNombreCliente_TextChanged;
            // 
            // txtNombrePlato
            // 
            txtNombrePlato.Location = new Point(24, 85);
            txtNombrePlato.Margin = new Padding(3, 2, 3, 2);
            txtNombrePlato.Name = "txtNombrePlato";
            txtNombrePlato.Size = new Size(180, 23);
            txtNombrePlato.TabIndex = 1;
            // 
            // txtMesa
            // 
            txtMesa.Location = new Point(342, 352);
            txtMesa.Margin = new Padding(3, 2, 3, 2);
            txtMesa.Name = "txtMesa";
            txtMesa.Size = new Size(110, 23);
            txtMesa.TabIndex = 2;
            // 
            // nombrecliente
            // 
            nombrecliente.AutoSize = true;
            nombrecliente.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nombrecliente.Location = new Point(24, 326);
            nombrecliente.Name = "nombrecliente";
            nombrecliente.Size = new Size(129, 19);
            nombrecliente.TabIndex = 4;
            nombrecliente.Text = "Nombre Del Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 56);
            label2.Name = "label2";
            label2.Size = new Size(117, 19);
            label2.TabIndex = 5;
            label2.Text = "Nombre Del Plato";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(342, 326);
            label3.Name = "label3";
            label3.Size = new Size(43, 19);
            label3.TabIndex = 6;
            label3.Text = "Mesa";
            label3.Click += label3_Click;
            // 
            // btnGenerarOrden
            // 
            btnGenerarOrden.BackColor = Color.Lime;
            btnGenerarOrden.FlatStyle = FlatStyle.Flat;
            btnGenerarOrden.Font = new Font("Impact", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGenerarOrden.Location = new Point(3, 291);
            btnGenerarOrden.Margin = new Padding(3, 2, 3, 2);
            btnGenerarOrden.Name = "btnGenerarOrden";
            btnGenerarOrden.Size = new Size(80, 48);
            btnGenerarOrden.TabIndex = 7;
            btnGenerarOrden.Text = "Finzalizar Orden";
            btnGenerarOrden.UseVisualStyleBackColor = false;
            btnGenerarOrden.Click += btnGenerarOrden_Click;
            // 
            // btnRegresaraMenu
            // 
            btnRegresaraMenu.BackColor = Color.MintCream;
            btnRegresaraMenu.FlatStyle = FlatStyle.Flat;
            btnRegresaraMenu.Font = new Font("Impact", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegresaraMenu.Location = new Point(105, 291);
            btnRegresaraMenu.Margin = new Padding(3, 2, 3, 2);
            btnRegresaraMenu.Name = "btnRegresaraMenu";
            btnRegresaraMenu.Size = new Size(82, 48);
            btnRegresaraMenu.TabIndex = 8;
            btnRegresaraMenu.Text = "Regresar";
            btnRegresaraMenu.UseVisualStyleBackColor = false;
            btnRegresaraMenu.Click += btnRegresaraMenu_Click;
            // 
            // btnAgregarPlato
            // 
            btnAgregarPlato.BackColor = Color.Lime;
            btnAgregarPlato.FlatStyle = FlatStyle.Flat;
            btnAgregarPlato.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregarPlato.Location = new Point(424, 79);
            btnAgregarPlato.Margin = new Padding(3, 2, 3, 2);
            btnAgregarPlato.Name = "btnAgregarPlato";
            btnAgregarPlato.Size = new Size(123, 32);
            btnAgregarPlato.TabIndex = 11;
            btnAgregarPlato.Text = "Agregar Plato";
            btnAgregarPlato.UseVisualStyleBackColor = false;
            btnAgregarPlato.Click += btnAgregarPlato_Click;
            // 
            // txtNitCliente
            // 
            txtNitCliente.Location = new Point(210, 352);
            txtNitCliente.Margin = new Padding(3, 2, 3, 2);
            txtNitCliente.Name = "txtNitCliente";
            txtNitCliente.Size = new Size(126, 23);
            txtNitCliente.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(210, 326);
            label1.Name = "label1";
            label1.Size = new Size(28, 19);
            label1.TabIndex = 13;
            label1.Text = "NIT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(24, 9);
            label4.Name = "label4";
            label4.Size = new Size(194, 20);
            label4.TabIndex = 14;
            label4.Text = "Ingrese los platos a la orden";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(24, 116);
            label5.Name = "label5";
            label5.Size = new Size(175, 19);
            label5.TabIndex = 15;
            label5.Text = "Platos listos para ordenar:";
            // 
            // dataGridViewPlatos
            // 
            dataGridViewPlatos.AllowUserToAddRows = false;
            dataGridViewPlatos.AllowUserToDeleteRows = false;
            dataGridViewPlatos.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewPlatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPlatos.Columns.AddRange(new DataGridViewColumn[] { Nombre, Detalle, Precio, Cantidad });
            dataGridViewPlatos.Location = new Point(24, 142);
            dataGridViewPlatos.Margin = new Padding(3, 2, 3, 2);
            dataGridViewPlatos.Name = "dataGridViewPlatos";
            dataGridViewPlatos.ReadOnly = true;
            dataGridViewPlatos.RowHeadersWidth = 51;
            dataGridViewPlatos.Size = new Size(566, 160);
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
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.Width = 125;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(3, 252);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(186, 35);
            button1.TabIndex = 17;
            button1.Text = "Eliminar plato de la orden";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(255, 85);
            txtCantidad.Margin = new Padding(3, 2, 3, 2);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(110, 23);
            txtCantidad.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(255, 56);
            label6.Name = "label6";
            label6.Size = new Size(66, 19);
            label6.TabIndex = 19;
            label6.Text = "Cantidad";
            // 
            // txtDetalleOrden
            // 
            txtDetalleOrden.Location = new Point(468, 352);
            txtDetalleOrden.Margin = new Padding(3, 2, 3, 2);
            txtDetalleOrden.Name = "txtDetalleOrden";
            txtDetalleOrden.Size = new Size(293, 23);
            txtDetalleOrden.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(468, 332);
            label7.Name = "label7";
            label7.Size = new Size(94, 19);
            label7.TabIndex = 21;
            label7.Text = "Detalle Orden";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Chocolate;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnRegresaraMenu);
            panel1.Controls.Add(btnGenerarOrden);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(596, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 341);
            panel1.TabIndex = 22;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.icons8_minimize_window_243;
            pictureBox3.Location = new Point(146, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(24, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 20;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_close_window_243;
            pictureBox2.Location = new Point(173, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_debug_blanco_removebg_preview3;
            pictureBox1.Location = new Point(0, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(197, 191);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            // 
            // Ordenes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(795, 400);
            Controls.Add(label7);
            Controls.Add(txtDetalleOrden);
            Controls.Add(panel1);
            Controls.Add(btnAgregarPlato);
            Controls.Add(label6);
            Controls.Add(txtCantidad);
            Controls.Add(dataGridViewPlatos);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(txtNitCliente);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(nombrecliente);
            Controls.Add(txtMesa);
            Controls.Add(txtNombrePlato);
            Controls.Add(txtNombreCliente);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Ordenes";
            Text = "Ordenes";
            Load += Ordenes_Load;
            MouseDown += Ordenes_MouseDown;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlatos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private TextBox txtNitCliente;
        private Label label1;
        private Label label4;
        private Label label5;
        private DataGridView dataGridViewPlatos;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Detalle;
        private DataGridViewTextBoxColumn Precio;
        private Button button1;
        private DataGridViewTextBoxColumn Cantidad;
        private TextBox txtCantidad;
        private Label label6;
        private TextBox txtDetalleOrden;
        private Label label7;
        private Panel panel1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}