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
            this.lblCodigoDeArticulo = new System.Windows.Forms.Label();
            this.txtBoxCodArticulo = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pctrBoxArticuloImagen = new System.Windows.Forms.PictureBox();
            this.txtBoxObjetoArticulo = new System.Windows.Forms.TextBox();
            this.lblTituloDetalleArticulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBoxArticuloImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigoDeArticulo
            // 
            this.lblCodigoDeArticulo.AutoSize = true;
            this.lblCodigoDeArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoDeArticulo.Location = new System.Drawing.Point(105, 108);
            this.lblCodigoDeArticulo.Name = "lblCodigoDeArticulo";
            this.lblCodigoDeArticulo.Size = new System.Drawing.Size(178, 25);
            this.lblCodigoDeArticulo.TabIndex = 0;
            this.lblCodigoDeArticulo.Text = "Código de Artículo:";
            // 
            // txtBoxCodArticulo
            // 
            this.txtBoxCodArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCodArticulo.Location = new System.Drawing.Point(317, 105);
            this.txtBoxCodArticulo.Name = "txtBoxCodArticulo";
            this.txtBoxCodArticulo.Size = new System.Drawing.Size(156, 27);
            this.txtBoxCodArticulo.TabIndex = 1;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(656, 458);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(99, 40);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // pctrBoxArticuloImagen
            // 
            this.pctrBoxArticuloImagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctrBoxArticuloImagen.Location = new System.Drawing.Point(624, 182);
            this.pctrBoxArticuloImagen.Name = "pctrBoxArticuloImagen";
            this.pctrBoxArticuloImagen.Size = new System.Drawing.Size(160, 175);
            this.pctrBoxArticuloImagen.TabIndex = 6;
            this.pctrBoxArticuloImagen.TabStop = false;
            // 
            // txtBoxObjetoArticulo
            // 
            this.txtBoxObjetoArticulo.Location = new System.Drawing.Point(49, 182);
            this.txtBoxObjetoArticulo.Multiline = true;
            this.txtBoxObjetoArticulo.Name = "txtBoxObjetoArticulo";
            this.txtBoxObjetoArticulo.Size = new System.Drawing.Size(527, 240);
            this.txtBoxObjetoArticulo.TabIndex = 5;
            // 
            // lblTituloDetalleArticulo
            // 
            this.lblTituloDetalleArticulo.AutoSize = true;
            this.lblTituloDetalleArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDetalleArticulo.Location = new System.Drawing.Point(105, 33);
            this.lblTituloDetalleArticulo.Name = "lblTituloDetalleArticulo";
            this.lblTituloDetalleArticulo.Size = new System.Drawing.Size(201, 25);
            this.lblTituloDetalleArticulo.TabIndex = 8;
            this.lblTituloDetalleArticulo.Text = "Detalle de un Artículo.";
            // 
            // frmVentanaDetalleArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.lblTituloDetalleArticulo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.pctrBoxArticuloImagen);
            this.Controls.Add(this.txtBoxObjetoArticulo);
            this.Controls.Add(this.txtBoxCodArticulo);
            this.Controls.Add(this.lblCodigoDeArticulo);
            this.Name = "frmVentanaDetalleArticulo";
            this.Text = "frmVentanaDetalleArticulo";
            ((System.ComponentModel.ISupportInitialize)(this.pctrBoxArticuloImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigoDeArticulo;
        private System.Windows.Forms.TextBox txtBoxCodArticulo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox pctrBoxArticuloImagen;
        private System.Windows.Forms.TextBox txtBoxObjetoArticulo;
        private System.Windows.Forms.Label lblTituloDetalleArticulo;
    }
}