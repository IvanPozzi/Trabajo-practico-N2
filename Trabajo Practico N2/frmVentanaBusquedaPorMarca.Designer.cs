namespace Trabajo_Practico_N2
{
    partial class frmVentanaBusquedaPorMarca
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
            this.lblMarca = new System.Windows.Forms.Label();
            this.cbBoxMarcaDesplegable = new System.Windows.Forms.ComboBox();
            this.txtBoxObjetoArticulo = new System.Windows.Forms.TextBox();
            this.pctrBoxArticuloImagen = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBoxArticuloImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(140, 90);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(73, 25);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca:";
            // 
            // cbBoxMarcaDesplegable
            // 
            this.cbBoxMarcaDesplegable.FormattingEnabled = true;
            this.cbBoxMarcaDesplegable.Location = new System.Drawing.Point(281, 90);
            this.cbBoxMarcaDesplegable.Name = "cbBoxMarcaDesplegable";
            this.cbBoxMarcaDesplegable.Size = new System.Drawing.Size(198, 24);
            this.cbBoxMarcaDesplegable.TabIndex = 1;
            // 
            // txtBoxObjetoArticulo
            // 
            this.txtBoxObjetoArticulo.Location = new System.Drawing.Point(95, 171);
            this.txtBoxObjetoArticulo.Multiline = true;
            this.txtBoxObjetoArticulo.Name = "txtBoxObjetoArticulo";
            this.txtBoxObjetoArticulo.Size = new System.Drawing.Size(527, 240);
            this.txtBoxObjetoArticulo.TabIndex = 2;
            // 
            // pctrBoxArticuloImagen
            // 
            this.pctrBoxArticuloImagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctrBoxArticuloImagen.Location = new System.Drawing.Point(642, 171);
            this.pctrBoxArticuloImagen.Name = "pctrBoxArticuloImagen";
            this.pctrBoxArticuloImagen.Size = new System.Drawing.Size(133, 141);
            this.pctrBoxArticuloImagen.TabIndex = 3;
            this.pctrBoxArticuloImagen.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(667, 427);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(99, 40);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // frmVentanaBusquedaPorMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.pctrBoxArticuloImagen);
            this.Controls.Add(this.txtBoxObjetoArticulo);
            this.Controls.Add(this.cbBoxMarcaDesplegable);
            this.Controls.Add(this.lblMarca);
            this.Name = "frmVentanaBusquedaPorMarca";
            this.Text = "frmVentanaBusquedaPorMarca";
            ((System.ComponentModel.ISupportInitialize)(this.pctrBoxArticuloImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cbBoxMarcaDesplegable;
        private System.Windows.Forms.TextBox txtBoxObjetoArticulo;
        private System.Windows.Forms.PictureBox pctrBoxArticuloImagen;
        private System.Windows.Forms.Button btnCerrar;
    }
}