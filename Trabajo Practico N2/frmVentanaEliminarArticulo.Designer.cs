namespace Trabajo_Practico_N2
{
    partial class frmVentanaEliminarArticulo
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
            this.pctrBoxArticuloImagen = new System.Windows.Forms.PictureBox();
            this.txtBoxObjetoArticulo = new System.Windows.Forms.TextBox();
            this.txtBoxCodArticulo = new System.Windows.Forms.TextBox();
            this.lblCodigoDeArticulo = new System.Windows.Forms.Label();
            this.lblCartelPreguntaEliminar = new System.Windows.Forms.Label();
            this.btnSI = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBoxArticuloImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // pctrBoxArticuloImagen
            // 
            this.pctrBoxArticuloImagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctrBoxArticuloImagen.Location = new System.Drawing.Point(608, 131);
            this.pctrBoxArticuloImagen.Name = "pctrBoxArticuloImagen";
            this.pctrBoxArticuloImagen.Size = new System.Drawing.Size(268, 190);
            this.pctrBoxArticuloImagen.TabIndex = 10;
            this.pctrBoxArticuloImagen.TabStop = false;
            // 
            // txtBoxObjetoArticulo
            // 
            this.txtBoxObjetoArticulo.Location = new System.Drawing.Point(33, 131);
            this.txtBoxObjetoArticulo.Multiline = true;
            this.txtBoxObjetoArticulo.Name = "txtBoxObjetoArticulo";
            this.txtBoxObjetoArticulo.Size = new System.Drawing.Size(527, 240);
            this.txtBoxObjetoArticulo.TabIndex = 9;
            // 
            // txtBoxCodArticulo
            // 
            this.txtBoxCodArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCodArticulo.Location = new System.Drawing.Point(280, 45);
            this.txtBoxCodArticulo.Name = "txtBoxCodArticulo";
            this.txtBoxCodArticulo.Size = new System.Drawing.Size(156, 27);
            this.txtBoxCodArticulo.TabIndex = 8;
            // 
            // lblCodigoDeArticulo
            // 
            this.lblCodigoDeArticulo.AutoSize = true;
            this.lblCodigoDeArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoDeArticulo.Location = new System.Drawing.Point(68, 48);
            this.lblCodigoDeArticulo.Name = "lblCodigoDeArticulo";
            this.lblCodigoDeArticulo.Size = new System.Drawing.Size(178, 25);
            this.lblCodigoDeArticulo.TabIndex = 7;
            this.lblCodigoDeArticulo.Text = "Código de Artículo:";
            // 
            // lblCartelPreguntaEliminar
            // 
            this.lblCartelPreguntaEliminar.AutoSize = true;
            this.lblCartelPreguntaEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartelPreguntaEliminar.Location = new System.Drawing.Point(141, 421);
            this.lblCartelPreguntaEliminar.Name = "lblCartelPreguntaEliminar";
            this.lblCartelPreguntaEliminar.Size = new System.Drawing.Size(270, 25);
            this.lblCartelPreguntaEliminar.TabIndex = 11;
            this.lblCartelPreguntaEliminar.Text = "¿Quiere eliminar ese artículo?";
            // 
            // btnSI
            // 
            this.btnSI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSI.Location = new System.Drawing.Point(171, 480);
            this.btnSI.Name = "btnSI";
            this.btnSI.Size = new System.Drawing.Size(81, 39);
            this.btnSI.TabIndex = 12;
            this.btnSI.Text = "SI";
            this.btnSI.UseVisualStyleBackColor = true;
            // 
            // btnNo
            // 
            this.btnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.Location = new System.Drawing.Point(312, 480);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(80, 39);
            this.btnNo.TabIndex = 13;
            this.btnNo.Text = "NO";
            this.btnNo.UseVisualStyleBackColor = true;
            // 
            // frmVentanaEliminarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnSI);
            this.Controls.Add(this.lblCartelPreguntaEliminar);
            this.Controls.Add(this.pctrBoxArticuloImagen);
            this.Controls.Add(this.txtBoxObjetoArticulo);
            this.Controls.Add(this.txtBoxCodArticulo);
            this.Controls.Add(this.lblCodigoDeArticulo);
            this.Name = "frmVentanaEliminarArticulo";
            this.Text = "frmVentanaEliminarArticulo";
            ((System.ComponentModel.ISupportInitialize)(this.pctrBoxArticuloImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctrBoxArticuloImagen;
        private System.Windows.Forms.TextBox txtBoxObjetoArticulo;
        private System.Windows.Forms.TextBox txtBoxCodArticulo;
        private System.Windows.Forms.Label lblCodigoDeArticulo;
        private System.Windows.Forms.Label lblCartelPreguntaEliminar;
        private System.Windows.Forms.Button btnSI;
        private System.Windows.Forms.Button btnNo;
    }
}