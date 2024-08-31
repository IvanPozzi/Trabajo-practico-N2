namespace Trabajo_Practico_N2
{
    partial class Ventana1
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
            this.btn1Agregar = new System.Windows.Forms.Button();
            this.cajatexto = new System.Windows.Forms.MaskedTextBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.btnagregararticulo = new System.Windows.Forms.Label();
            this.codarticulo = new System.Windows.Forms.Label();
            this.Descripcon = new System.Windows.Forms.Label();
            this.Precio = new System.Windows.Forms.Label();
            this.Marca = new System.Windows.Forms.Label();
            this.Categoria = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn1Agregar
            // 
            this.btn1Agregar.Location = new System.Drawing.Point(158, 350);
            this.btn1Agregar.Name = "btn1Agregar";
            this.btn1Agregar.Size = new System.Drawing.Size(100, 45);
            this.btn1Agregar.TabIndex = 0;
            this.btn1Agregar.Text = "Agregar";
            this.btn1Agregar.UseVisualStyleBackColor = true;
            this.btn1Agregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cajatexto
            // 
            this.cajatexto.Location = new System.Drawing.Point(158, 61);
            this.cajatexto.Name = "cajatexto";
            this.cajatexto.Size = new System.Drawing.Size(100, 26);
            this.cajatexto.TabIndex = 1;
            this.cajatexto.Enter += new System.EventHandler(this.maskedTextBox1_Enter);
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(12, 106);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(69, 20);
            this.Nombre.TabIndex = 2;
            this.Nombre.Text = "Nombre:";
            // 
            // btnagregararticulo
            // 
            this.btnagregararticulo.AutoSize = true;
            this.btnagregararticulo.Location = new System.Drawing.Point(12, 19);
            this.btnagregararticulo.Name = "btnagregararticulo";
            this.btnagregararticulo.Size = new System.Drawing.Size(125, 20);
            this.btnagregararticulo.TabIndex = 3;
            this.btnagregararticulo.Text = "Agregar artículo:";
            // 
            // codarticulo
            // 
            this.codarticulo.AutoSize = true;
            this.codarticulo.Location = new System.Drawing.Point(12, 61);
            this.codarticulo.Name = "codarticulo";
            this.codarticulo.Size = new System.Drawing.Size(140, 20);
            this.codarticulo.TabIndex = 4;
            this.codarticulo.Text = "Código de artículo:";
            // 
            // Descripcon
            // 
            this.Descripcon.AutoSize = true;
            this.Descripcon.Location = new System.Drawing.Point(12, 151);
            this.Descripcon.Name = "Descripcon";
            this.Descripcon.Size = new System.Drawing.Size(96, 20);
            this.Descripcon.TabIndex = 5;
            this.Descripcon.Text = "Descripcion:";
            // 
            // Precio
            // 
            this.Precio.AutoSize = true;
            this.Precio.Location = new System.Drawing.Point(12, 292);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(61, 20);
            this.Precio.TabIndex = 6;
            this.Precio.Text = "Precio :";
            // 
            // Marca
            // 
            this.Marca.AutoSize = true;
            this.Marca.Location = new System.Drawing.Point(12, 195);
            this.Marca.Name = "Marca";
            this.Marca.Size = new System.Drawing.Size(57, 20);
            this.Marca.TabIndex = 7;
            this.Marca.Text = "Marca:";
            // 
            // Categoria
            // 
            this.Categoria.AutoSize = true;
            this.Categoria.Location = new System.Drawing.Point(12, 243);
            this.Categoria.Name = "Categoria";
            this.Categoria.Size = new System.Drawing.Size(82, 20);
            this.Categoria.TabIndex = 8;
            this.Categoria.Text = "Categoria:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(158, 106);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 26);
            this.maskedTextBox1.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(158, 195);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 13;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(158, 243);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 28);
            this.comboBox2.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(158, 151);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 16;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(158, 292);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 17;
            // 
            // Ventana1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 434);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.Categoria);
            this.Controls.Add(this.Marca);
            this.Controls.Add(this.Precio);
            this.Controls.Add(this.Descripcon);
            this.Controls.Add(this.codarticulo);
            this.Controls.Add(this.btnagregararticulo);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.cajatexto);
            this.Controls.Add(this.btn1Agregar);
            this.Name = "Ventana1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargar Articulo";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1Agregar;
        private System.Windows.Forms.MaskedTextBox cajatexto;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label btnagregararticulo;
        private System.Windows.Forms.Label codarticulo;
        private System.Windows.Forms.Label Descripcon;
        private System.Windows.Forms.Label Precio;
        private System.Windows.Forms.Label Marca;
        private System.Windows.Forms.Label Categoria;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}