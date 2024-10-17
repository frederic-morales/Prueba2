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
            txtNombrePlato = new TextBox();
            txtNit = new TextBox();
            Label = new Label();
            label1 = new Label();
            btnAgregar = new Button();
            btnRegresar = new Button();
            SuspendLayout();
            // 
            // txtNombrePlato
            // 
            txtNombrePlato.Location = new Point(59, 84);
            txtNombrePlato.Name = "txtNombrePlato";
            txtNombrePlato.Size = new Size(125, 27);
            txtNombrePlato.TabIndex = 0;
            // 
            // txtNit
            // 
            txtNit.Location = new Point(59, 176);
            txtNit.Name = "txtNit";
            txtNit.Size = new Size(125, 27);
            txtNit.TabIndex = 1;
            // 
            // Label
            // 
            Label.AutoSize = true;
            Label.Location = new Point(59, 51);
            Label.Name = "Label";
            Label.Size = new Size(98, 20);
            Label.TabIndex = 2;
            Label.Text = "NombrePlato";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 143);
            label1.Name = "label1";
            label1.Size = new Size(32, 20);
            label1.TabIndex = 3;
            label1.Text = "NIT";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(533, 250);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
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
            // Plato
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegresar);
            Controls.Add(btnAgregar);
            Controls.Add(label1);
            Controls.Add(Label);
            Controls.Add(txtNit);
            Controls.Add(txtNombrePlato);
            Name = "Plato";
            Text = "Plato";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombrePlato;
        private TextBox txtNit;
        private Label Label;
        private Label label1;
        private Button btnAgregar;
        private Button btnRegresar;
    }
}