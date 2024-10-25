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
            label1.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(101, 114);
            label1.Name = "label1";
            label1.Size = new Size(140, 20);
            label1.TabIndex = 7;
            label1.Text = "Descripcion Factura";
            // 
            // IdOrden
            // 
            IdOrden.AutoSize = true;
            IdOrden.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IdOrden.Location = new Point(135, 65);
            IdOrden.Name = "IdOrden";
            IdOrden.Size = new Size(61, 20);
            IdOrden.TabIndex = 6;
            IdOrden.Text = "IdOrden";
            // 
            // txtDescripcionFactura
            // 
            txtDescripcionFactura.Location = new Point(247, 111);
            txtDescripcionFactura.Margin = new Padding(3, 2, 3, 2);
            txtDescripcionFactura.Name = "txtDescripcionFactura";
            txtDescripcionFactura.Size = new Size(287, 23);
            txtDescripcionFactura.TabIndex = 5;
            // 
            // txtIdOrden
            // 
            txtIdOrden.Location = new Point(247, 62);
            txtIdOrden.Margin = new Padding(3, 2, 3, 2);
            txtIdOrden.Name = "txtIdOrden";
            txtIdOrden.Size = new Size(287, 23);
            txtIdOrden.TabIndex = 4;
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.SteelBlue;
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegresar.Location = new Point(389, 201);
            btnRegresar.Margin = new Padding(3, 2, 3, 2);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(145, 29);
            btnRegresar.TabIndex = 9;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnGenerarFactura
            // 
            btnGenerarFactura.BackColor = Color.Lime;
            btnGenerarFactura.FlatStyle = FlatStyle.Flat;
            btnGenerarFactura.Font = new Font("Impact", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGenerarFactura.Location = new Point(183, 201);
            btnGenerarFactura.Margin = new Padding(3, 2, 3, 2);
            btnGenerarFactura.Name = "btnGenerarFactura";
            btnGenerarFactura.Size = new Size(140, 29);
            btnGenerarFactura.TabIndex = 8;
            btnGenerarFactura.Text = "Generar Factura";
            btnGenerarFactura.UseVisualStyleBackColor = false;
            btnGenerarFactura.Click += btnGenerarFactura_Click;
            // 
            // Facturas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(700, 338);
            Controls.Add(btnRegresar);
            Controls.Add(btnGenerarFactura);
            Controls.Add(label1);
            Controls.Add(IdOrden);
            Controls.Add(txtDescripcionFactura);
            Controls.Add(txtIdOrden);
            Margin = new Padding(3, 2, 3, 2);
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