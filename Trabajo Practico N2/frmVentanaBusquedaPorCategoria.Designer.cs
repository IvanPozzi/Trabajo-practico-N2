namespace Trabajo_Practico_N2
{
    partial class frmVentanaBusquedaPorCategoria
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
            this.lblCategoria = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pctrBoxArticuloImagen = new System.Windows.Forms.PictureBox();
            this.txtBoxObjetoArticulo = new System.Windows.Forms.TextBox();
            this.cbBoxCategoriaDesplegable = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBoxArticuloImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(147, 77);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(103, 25);
            this.lblCategoria.TabIndex = 0;
            this.lblCategoria.Text = "Categoria:";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(711, 461);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(99, 40);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // pctrBoxArticuloImagen
            // 
            this.pctrBoxArticuloImagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctrBoxArticuloImagen.Location = new System.Drawing.Point(686, 205);
            this.pctrBoxArticuloImagen.Name = "pctrBoxArticuloImagen";
            this.pctrBoxArticuloImagen.Size = new System.Drawing.Size(133, 141);
            this.pctrBoxArticuloImagen.TabIndex = 6;
            this.pctrBoxArticuloImagen.TabStop = false;
            // 
            // txtBoxObjetoArticulo
            // 
            this.txtBoxObjetoArticulo.Location = new System.Drawing.Point(139, 205);
            this.txtBoxObjetoArticulo.Multiline = true;
            this.txtBoxObjetoArticulo.Name = "txtBoxObjetoArticulo";
            this.txtBoxObjetoArticulo.Size = new System.Drawing.Size(527, 240);
            this.txtBoxObjetoArticulo.TabIndex = 5;
            // 
            // cbBoxCategoriaDesplegable
            // 
            this.cbBoxCategoriaDesplegable.FormattingEnabled = true;
            this.cbBoxCategoriaDesplegable.Location = new System.Drawing.Point(300, 77);
            this.cbBoxCategoriaDesplegable.Name = "cbBoxCategoriaDesplegable";
            this.cbBoxCategoriaDesplegable.Size = new System.Drawing.Size(223, 24);
            this.cbBoxCategoriaDesplegable.TabIndex = 8;
            // 
            // frmVentanaBusquedaPorCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.cbBoxCategoriaDesplegable);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.pctrBoxArticuloImagen);
            this.Controls.Add(this.txtBoxObjetoArticulo);
            this.Controls.Add(this.lblCategoria);
            this.Name = "frmVentanaBusquedaPorCategoria";
            this.Text = "frmVentanaBusquedaPorCategoria";
            ((System.ComponentModel.ISupportInitialize)(this.pctrBoxArticuloImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox pctrBoxArticuloImagen;
        private System.Windows.Forms.TextBox txtBoxObjetoArticulo;
        private System.Windows.Forms.ComboBox cbBoxCategoriaDesplegable;
    }
}