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
            this.txtcodigo = new System.Windows.Forms.MaskedTextBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.btnagregararticulo = new System.Windows.Forms.Label();
            this.codarticulo = new System.Windows.Forms.Label();
            this.Descripcon = new System.Windows.Forms.Label();
            this.Precio = new System.Windows.Forms.Label();
            this.Marca = new System.Windows.Forms.Label();
            this.Categoria = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.MaskedTextBox();
            this.txtmarca = new System.Windows.Forms.ComboBox();
            this.txtcategoria = new System.Windows.Forms.ComboBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btncancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn1Agregar
            // 
            this.btn1Agregar.Location = new System.Drawing.Point(72, 362);
            this.btn1Agregar.Name = "btn1Agregar";
            this.btn1Agregar.Size = new System.Drawing.Size(100, 45);
            this.btn1Agregar.TabIndex = 0;
            this.btn1Agregar.Text = "Agregar";
            this.btn1Agregar.UseVisualStyleBackColor = true;
            this.btn1Agregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(158, 61);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(100, 26);
            this.txtcodigo.TabIndex = 1;
            this.txtcodigo.Enter += new System.EventHandler(this.maskedTextBox1_Enter);
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
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(158, 106);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 26);
            this.txtnombre.TabIndex = 9;
            // 
            // txtmarca
            // 
            this.txtmarca.FormattingEnabled = true;
            this.txtmarca.Items.AddRange(new object[] {
            "samsung",
            "apple",
            "sony",
            "huawei",
            "motorola"});
            this.txtmarca.Location = new System.Drawing.Point(158, 195);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(121, 28);
            this.txtmarca.TabIndex = 13;
            // 
            // txtcategoria
            // 
            this.txtcategoria.FormattingEnabled = true;
            this.txtcategoria.Items.AddRange(new object[] {
            "celulares",
            "televisores",
            "media",
            "audio"});
            this.txtcategoria.Location = new System.Drawing.Point(158, 243);
            this.txtcategoria.Name = "txtcategoria";
            this.txtcategoria.Size = new System.Drawing.Size(121, 28);
            this.txtcategoria.TabIndex = 14;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(158, 151);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(100, 26);
            this.txtdescripcion.TabIndex = 16;
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
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(232, 362);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(100, 45);
            this.btncancel.TabIndex = 18;
            this.btncancel.Text = "cancelar";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // Ventana1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 434);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.txtcategoria);
            this.Controls.Add(this.txtmarca);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.Categoria);
            this.Controls.Add(this.Marca);
            this.Controls.Add(this.Precio);
            this.Controls.Add(this.Descripcon);
            this.Controls.Add(this.codarticulo);
            this.Controls.Add(this.btnagregararticulo);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.txtcodigo);
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
        private System.Windows.Forms.MaskedTextBox txtcodigo;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label btnagregararticulo;
        private System.Windows.Forms.Label codarticulo;
        private System.Windows.Forms.Label Descripcon;
        private System.Windows.Forms.Label Precio;
        private System.Windows.Forms.Label Marca;
        private System.Windows.Forms.Label Categoria;
        private System.Windows.Forms.MaskedTextBox txtnombre;
        private System.Windows.Forms.ComboBox txtmarca;
        private System.Windows.Forms.ComboBox txtcategoria;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btncancel;
    }
}