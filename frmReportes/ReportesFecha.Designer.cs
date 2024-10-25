namespace frmReportes
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
            dataGridView1 = new DataGridView();
            fechaInicial = new DateTimePicker();
            fechaFinal = new DateTimePicker();
            btnGenerarReporte = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(40, 139);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(661, 221);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // fechaInicial
            // 
            fechaInicial.Location = new Point(89, 91);
            fechaInicial.Name = "fechaInicial";
            fechaInicial.Size = new Size(117, 23);
            fechaInicial.TabIndex = 1;
            fechaInicial.ValueChanged += fechaInicial_ValueChanged;
            // 
            // fechaFinal
            // 
            fechaFinal.Location = new Point(295, 91);
            fechaFinal.Name = "fechaFinal";
            fechaFinal.Size = new Size(98, 23);
            fechaFinal.TabIndex = 2;
            // 
            // btnGenerarReporte
            // 
            btnGenerarReporte.BackColor = Color.Lime;
            btnGenerarReporte.FlatStyle = FlatStyle.Flat;
            btnGenerarReporte.Font = new Font("Impact", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGenerarReporte.Location = new Point(611, 90);
            btnGenerarReporte.Name = "btnGenerarReporte";
            btnGenerarReporte.Size = new Size(142, 24);
            btnGenerarReporte.TabIndex = 3;
            btnGenerarReporte.Text = "Generar Reporte";
            btnGenerarReporte.UseVisualStyleBackColor = false;
            btnGenerarReporte.Click += btnGenerarReporte_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 96);
            label1.Name = "label1";
            label1.Size = new Size(73, 17);
            label1.TabIndex = 4;
            label1.Text = "Fecha incio:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(224, 98);
            label2.Name = "label2";
            label2.Size = new Size(61, 17);
            label2.TabIndex = 5;
            label2.Text = "Fecha Fin:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(254, 32);
            label3.Name = "label3";
            label3.Size = new Size(237, 23);
            label3.TabIndex = 6;
            label3.Text = "REPORTE DE VENTAS GENERALES";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(486, 91);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(107, 23);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(399, 98);
            label4.Name = "label4";
            label4.Size = new Size(81, 17);
            label4.TabIndex = 8;
            label4.Text = "Tipo Reporte:";
            label4.Click += label4_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Impact", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(611, 390);
            button1.Name = "button1";
            button1.Size = new Size(142, 35);
            button1.TabIndex = 9;
            button1.Text = "Regresar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGenerarReporte);
            Controls.Add(fechaFinal);
            Controls.Add(fechaInicial);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DateTimePicker fechaInicial;
        private DateTimePicker fechaFinal;
        private Button btnGenerarReporte;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        private Button button1;
    }
}
