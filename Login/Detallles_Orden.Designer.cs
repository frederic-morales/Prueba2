namespace Login
{
    partial class Detallles_Orden
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
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            btnAgregarPlato = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(41, 83);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 48);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 1;
            label1.Text = "Nuevo Plato";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(41, 214);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 167);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 3;
            label2.Text = "Cantidad de Plato";
            // 
            // btnAgregarPlato
            // 
            btnAgregarPlato.Location = new Point(303, 81);
            btnAgregarPlato.Name = "btnAgregarPlato";
            btnAgregarPlato.Size = new Size(94, 29);
            btnAgregarPlato.TabIndex = 4;
            btnAgregarPlato.Text = "Agregar Plato";
            btnAgregarPlato.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(664, 388);
            button1.Name = "button1";
            button1.Size = new Size(101, 33);
            button1.TabIndex = 5;
            button1.Text = "Regresar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Detallles_Orden
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnAgregarPlato);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Detallles_Orden";
            Text = "Detallles_Orden";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private Button btnAgregarPlato;
        private Button button1;
    }
}