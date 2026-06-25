namespace PryTaquilla.Boleto
{
    partial class FrmBoleto
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
            groupBox1 = new GroupBox();
            cbTipo = new ComboBox();
            cbCategoria = new ComboBox();
            numCantidad = new NumericUpDown();
            btComprar = new Button();
            label3 = new Label();
            label2 = new Label();
            labl1 = new Label();
            groupBox = new GroupBox();
            txtINAPAM = new TextBox();
            txtMatricula = new TextBox();
            textBox1 = new TextBox();
            lblINAPAM = new Label();
            lblMatricula = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            panel3 = new Panel();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            panel2 = new Panel();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            label4 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            groupBox.SuspendLayout();
            groupBox3.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbTipo);
            groupBox1.Controls.Add(cbCategoria);
            groupBox1.Controls.Add(numCantidad);
            groupBox1.Controls.Add(btComprar);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(labl1);
            groupBox1.Location = new Point(419, 221);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(509, 324);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalle";
            // 
            // cbTipo
            // 
            cbTipo.FormattingEnabled = true;
            cbTipo.Location = new Point(177, 130);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(151, 28);
            cbTipo.TabIndex = 6;
            cbTipo.SelectedIndexChanged += cbTipo_SelectedIndexChanged;
            // 
            // cbCategoria
            // 
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(177, 46);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(151, 28);
            cbCategoria.TabIndex = 5;
            // 
            // numCantidad
            // 
            numCantidad.Location = new Point(177, 217);
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(150, 27);
            numCantidad.TabIndex = 4;
            // 
            // btComprar
            // 
            btComprar.Location = new Point(378, 149);
            btComprar.Name = "btComprar";
            btComprar.Size = new Size(94, 29);
            btComprar.TabIndex = 3;
            btComprar.Text = "Comprar";
            btComprar.UseVisualStyleBackColor = true;
            btComprar.Click += btComprar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 224);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 2;
            label3.Text = "Cantidad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 138);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 1;
            label2.Text = "Tipo";
            // 
            // labl1
            // 
            labl1.AutoSize = true;
            labl1.Location = new Point(18, 46);
            labl1.Name = "labl1";
            labl1.Size = new Size(74, 20);
            labl1.TabIndex = 0;
            labl1.Text = "Categoria";
            // 
            // groupBox
            // 
            groupBox.Controls.Add(txtINAPAM);
            groupBox.Controls.Add(txtMatricula);
            groupBox.Controls.Add(textBox1);
            groupBox.Controls.Add(lblINAPAM);
            groupBox.Controls.Add(lblMatricula);
            groupBox.Controls.Add(label1);
            groupBox.Location = new Point(12, 221);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(377, 336);
            groupBox.TabIndex = 1;
            groupBox.TabStop = false;
            groupBox.Text = "Informacion";
            groupBox.Enter += groupBox2_Enter;
            // 
            // txtINAPAM
            // 
            txtINAPAM.Location = new Point(134, 224);
            txtINAPAM.Name = "txtINAPAM";
            txtINAPAM.Size = new Size(125, 27);
            txtINAPAM.TabIndex = 12;
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(134, 138);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(125, 27);
            txtMatricula.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(134, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 10;
            // 
            // lblINAPAM
            // 
            lblINAPAM.AutoSize = true;
            lblINAPAM.Location = new Point(11, 224);
            lblINAPAM.Name = "lblINAPAM";
            lblINAPAM.Size = new Size(64, 20);
            lblINAPAM.TabIndex = 9;
            lblINAPAM.Text = "INAPAM";
            // 
            // lblMatricula
            // 
            lblMatricula.AutoSize = true;
            lblMatricula.Location = new Point(11, 138);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(71, 20);
            lblMatricula.TabIndex = 8;
            lblMatricula.Text = "Matricula";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 46);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 7;
            label1.Text = "Nombre";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(panel3);
            groupBox3.Controls.Add(panel2);
            groupBox3.Controls.Add(panel1);
            groupBox3.Location = new Point(12, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(922, 203);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // panel3
            // 
            panel3.BackColor = Color.RosyBrown;
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label10);
            panel3.Location = new Point(613, 40);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 125);
            panel3.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(93, 18);
            label12.Name = "label12";
            label12.Size = new Size(54, 20);
            label12.TabIndex = 17;
            label12.Text = "Adulto";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(93, 86);
            label11.Name = "label11";
            label11.Size = new Size(81, 20);
            label11.TabIndex = 17;
            label11.Text = "Precio: $25";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(58, 51);
            label10.Name = "label10";
            label10.Size = new Size(136, 20);
            label10.TabIndex = 17;
            label10.Text = "Descuento del %50";
            // 
            // panel2
            // 
            panel2.BackColor = Color.RosyBrown;
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(321, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 125);
            panel2.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(94, 86);
            label9.Name = "label9";
            label9.Size = new Size(81, 20);
            label9.TabIndex = 15;
            label9.Text = "Precio: $35";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(63, 51);
            label8.Name = "label8";
            label8.Size = new Size(136, 20);
            label8.TabIndex = 16;
            label8.Text = "Descuento del %25";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(86, 18);
            label7.Name = "label7";
            label7.Size = new Size(78, 20);
            label7.TabIndex = 15;
            label7.Text = "Estudiante";
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(28, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 125);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(71, 63);
            label6.Name = "label6";
            label6.Size = new Size(81, 20);
            label6.TabIndex = 14;
            label6.Text = "Precio: $50";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(80, 30);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 13;
            label4.Text = "General";
            // 
            // FrmBoleto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1082, 557);
            Controls.Add(groupBox3);
            Controls.Add(groupBox);
            Controls.Add(groupBox1);
            Name = "FrmBoleto";
            Text = "FrmBoleto";
            Load += FrmBoleto_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            groupBox3.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label labl1;
        private ComboBox cbTipo;
        private ComboBox cbCategoria;
        private NumericUpDown numCantidad;
        private Button btComprar;
        private GroupBox groupBox;
        private Label label1;
        private TextBox txtINAPAM;
        private TextBox txtMatricula;
        private TextBox textBox1;
        private Label lblINAPAM;
        private Label lblMatricula;
        private GroupBox groupBox3;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label4;
    }
}