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
            labl1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btComprar = new Button();
            numCantidad = new NumericUpDown();
            cbCategoria = new ComboBox();
            cbTipo = new ComboBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
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
            groupBox1.Location = new Point(15, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(519, 324);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // labl1
            // 
            labl1.AutoSize = true;
            labl1.Location = new Point(17, 26);
            labl1.Name = "labl1";
            labl1.Size = new Size(74, 20);
            labl1.TabIndex = 0;
            labl1.Text = "Categoria";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 97);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 1;
            label2.Text = "Tipo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 161);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 2;
            label3.Text = "Cantidad";
            // 
            // btComprar
            // 
            btComprar.Location = new Point(177, 255);
            btComprar.Name = "btComprar";
            btComprar.Size = new Size(94, 29);
            btComprar.TabIndex = 3;
            btComprar.Text = "Comprar";
            btComprar.UseVisualStyleBackColor = true;
            btComprar.Click += btComprar_Click;
            // 
            // numCantidad
            // 
            numCantidad.Location = new Point(23, 198);
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(150, 27);
            numCantidad.TabIndex = 4;
            // 
            // cbCategoria
            // 
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(21, 66);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(151, 28);
            cbCategoria.TabIndex = 5;
            // 
            // cbTipo
            // 
            cbTipo.FormattingEnabled = true;
            cbTipo.Location = new Point(21, 130);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(151, 28);
            cbTipo.TabIndex = 6;
            // 
            // FrmBoleto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "FrmBoleto";
            Text = "FrmBoleto";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
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
    }
}