namespace Login
{
    partial class Facturas
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
            IdOrden = new Label();
            txtDescripcionFactura = new TextBox();
            txtIdOrden = new TextBox();
            btnRegresar = new Button();
            btnGenerarFactura = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 151);
            label1.Name = "label1";
            label1.Size = new Size(138, 20);
            label1.TabIndex = 7;
            label1.Text = "Descripcion Factura";
            // 
            // IdOrden
            // 
            IdOrden.AutoSize = true;
            IdOrden.Location = new Point(156, 90);
            IdOrden.Name = "IdOrden";
            IdOrden.Size = new Size(63, 20);
            IdOrden.TabIndex = 6;
            IdOrden.Text = "IdOrden";
            // 
            // txtDescripcionFactura
            // 
            txtDescripcionFactura.Location = new Point(282, 148);
            txtDescripcionFactura.Name = "txtDescripcionFactura";
            txtDescripcionFactura.Size = new Size(327, 27);
            txtDescripcionFactura.TabIndex = 5;
            // 
            // txtIdOrden
            // 
            txtIdOrden.Location = new Point(282, 83);
            txtIdOrden.Name = "txtIdOrden";
            txtIdOrden.Size = new Size(327, 27);
            txtIdOrden.TabIndex = 4;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(445, 268);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(94, 39);
            btnRegresar.TabIndex = 9;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            // 
            // btnGenerarFactura
            // 
            btnGenerarFactura.Location = new Point(245, 268);
            btnGenerarFactura.Name = "btnGenerarFactura";
            btnGenerarFactura.Size = new Size(142, 39);
            btnGenerarFactura.TabIndex = 8;
            btnGenerarFactura.Text = "Generar Factura";
            btnGenerarFactura.UseVisualStyleBackColor = true;
            btnGenerarFactura.Click += btnGenerarFactura_Click;
            // 
            // Facturas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegresar);
            Controls.Add(btnGenerarFactura);
            Controls.Add(label1);
            Controls.Add(IdOrden);
            Controls.Add(txtDescripcionFactura);
            Controls.Add(txtIdOrden);
            Name = "Facturas";
            Text = "Facturas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label IdOrden;
        private TextBox txtDescripcionFactura;
        private TextBox txtIdOrden;
        private Button btnRegresar;
        private Button btnGenerarFactura;
    }
}