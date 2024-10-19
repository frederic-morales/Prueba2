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
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            NombrePlato = new Label();
            label1 = new Label();
            btnAgregar = new Button();
            btnRegresar = new Button();
            label2 = new Label();
            txtDetallePlato = new TextBox();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(59, 84);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 0;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(59, 176);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(125, 27);
            txtPrecio.TabIndex = 1;
            // 
            // NombrePlato
            // 
            NombrePlato.AutoSize = true;
            NombrePlato.Location = new Point(59, 51);
            NombrePlato.Name = "NombrePlato";
            NombrePlato.Size = new Size(127, 20);
            NombrePlato.TabIndex = 2;
            NombrePlato.Text = "Nombre del Plato";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 143);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 3;
            label1.Text = "Precio";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(533, 250);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(669, 409);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(94, 29);
            btnRegresar.TabIndex = 5;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 240);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 7;
            label2.Text = "Detalles del plato";
            // 
            // txtDetallePlato
            // 
            txtDetallePlato.Location = new Point(59, 273);
            txtDetallePlato.Name = "txtDetallePlato";
            txtDetallePlato.Size = new Size(125, 27);
            txtDetallePlato.TabIndex = 6;
            // 
            // Plato
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(txtDetallePlato);
            Controls.Add(btnRegresar);
            Controls.Add(btnAgregar);
            Controls.Add(label1);
            Controls.Add(NombrePlato);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Name = "Plato";
            Text = "Plato";
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
    }
}