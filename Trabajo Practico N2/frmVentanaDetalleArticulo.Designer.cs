namespace Trabajo_Practico_N2
{
    partial class frmVentanaDetalleArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentanaDetalleArticulo));
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCodigoArticulo = new System.Windows.Forms.Label();
            this.lblDescripcionArticulo = new System.Windows.Forms.Label();
            this.lblCategoriaArticulo = new System.Windows.Forms.Label();
            this.lblMarcaArticulo = new System.Windows.Forms.Label();
            this.lblPrecioArticulo = new System.Windows.Forms.Label();
            this.lblNombreArticulo = new System.Windows.Forms.Label();
            this.ptbImagenDetalle = new System.Windows.Forms.PictureBox();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagenDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(1419, 652);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(111, 49);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitulo.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(114, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(276, 39);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Detalle de Articulo";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCodigo.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(75, 103);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(109, 35);
            this.lblCodigo.TabIndex = 9;
            this.lblCodigo.Text = "Codigo:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNombre.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(75, 175);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(118, 35);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDescripcion.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(75, 243);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(171, 35);
            this.lblDescripcion.TabIndex = 11;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCategoria.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(75, 318);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(144, 35);
            this.lblCategoria.TabIndex = 12;
            this.lblCategoria.Text = "Categoria:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPrecio.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(75, 447);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(101, 35);
            this.lblPrecio.TabIndex = 14;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.BackColor = System.Drawing.Color.Transparent;
            this.lblMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMarca.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(75, 381);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(99, 35);
            this.lblMarca.TabIndex = 15;
            this.lblMarca.Text = "Marca:";
            // 
            // lblCodigoArticulo
            // 
            this.lblCodigoArticulo.AutoSize = true;
            this.lblCodigoArticulo.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigoArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCodigoArticulo.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoArticulo.Location = new System.Drawing.Point(287, 103);
            this.lblCodigoArticulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoArticulo.Name = "lblCodigoArticulo";
            this.lblCodigoArticulo.Size = new System.Drawing.Size(0, 35);
            this.lblCodigoArticulo.TabIndex = 9;
            // 
            // lblDescripcionArticulo
            // 
            this.lblDescripcionArticulo.AutoSize = true;
            this.lblDescripcionArticulo.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcionArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDescripcionArticulo.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionArticulo.Location = new System.Drawing.Point(287, 243);
            this.lblDescripcionArticulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcionArticulo.Name = "lblDescripcionArticulo";
            this.lblDescripcionArticulo.Size = new System.Drawing.Size(0, 35);
            this.lblDescripcionArticulo.TabIndex = 11;
            // 
            // lblCategoriaArticulo
            // 
            this.lblCategoriaArticulo.AutoSize = true;
            this.lblCategoriaArticulo.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoriaArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCategoriaArticulo.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaArticulo.Location = new System.Drawing.Point(287, 318);
            this.lblCategoriaArticulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoriaArticulo.Name = "lblCategoriaArticulo";
            this.lblCategoriaArticulo.Size = new System.Drawing.Size(0, 35);
            this.lblCategoriaArticulo.TabIndex = 12;
            // 
            // lblMarcaArticulo
            // 
            this.lblMarcaArticulo.AutoSize = true;
            this.lblMarcaArticulo.BackColor = System.Drawing.Color.Transparent;
            this.lblMarcaArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMarcaArticulo.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaArticulo.Location = new System.Drawing.Point(246, 381);
            this.lblMarcaArticulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarcaArticulo.Name = "lblMarcaArticulo";
            this.lblMarcaArticulo.Size = new System.Drawing.Size(0, 35);
            this.lblMarcaArticulo.TabIndex = 15;
            // 
            // lblPrecioArticulo
            // 
            this.lblPrecioArticulo.AutoSize = true;
            this.lblPrecioArticulo.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecioArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPrecioArticulo.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioArticulo.Location = new System.Drawing.Point(246, 447);
            this.lblPrecioArticulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioArticulo.Name = "lblPrecioArticulo";
            this.lblPrecioArticulo.Size = new System.Drawing.Size(0, 35);
            this.lblPrecioArticulo.TabIndex = 14;
            // 
            // lblNombreArticulo
            // 
            this.lblNombreArticulo.AutoSize = true;
            this.lblNombreArticulo.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNombreArticulo.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreArticulo.Location = new System.Drawing.Point(287, 175);
            this.lblNombreArticulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreArticulo.Name = "lblNombreArticulo";
            this.lblNombreArticulo.Size = new System.Drawing.Size(0, 35);
            this.lblNombreArticulo.TabIndex = 10;
            // 
            // ptbImagenDetalle
            // 
            this.ptbImagenDetalle.Location = new System.Drawing.Point(610, 87);
            this.ptbImagenDetalle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ptbImagenDetalle.Name = "ptbImagenDetalle";
            this.ptbImagenDetalle.Size = new System.Drawing.Size(417, 395);
            this.ptbImagenDetalle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbImagenDetalle.TabIndex = 16;
            this.ptbImagenDetalle.TabStop = false;
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(56, 652);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(140, 49);
            this.btnModificar.TabIndex = 17;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // frmVentanaDetalleArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1082, 547);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.ptbImagenDetalle);
            this.Controls.Add(this.lblMarcaArticulo);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblPrecioArticulo);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCategoriaArticulo);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblDescripcionArticulo);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombreArticulo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigoArticulo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnCerrar);
            this.ForeColor = System.Drawing.Color.Orange;
            this.Name = "frmVentanaDetalleArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle de articulo";
            this.Load += new System.EventHandler(this.frmVentanaDetalleArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagenDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCodigoArticulo;
        private System.Windows.Forms.Label lblDescripcionArticulo;
        private System.Windows.Forms.Label lblCategoriaArticulo;
        private System.Windows.Forms.Label lblMarcaArticulo;
        private System.Windows.Forms.Label lblPrecioArticulo;
        private System.Windows.Forms.Label lblNombreArticulo;
        private System.Windows.Forms.PictureBox ptbImagenDetalle;
        private System.Windows.Forms.Button btnModificar;
    }
}