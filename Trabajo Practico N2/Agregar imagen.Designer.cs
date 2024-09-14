namespace Trabajo_Practico_N2
{
    partial class frmAgregarimagen
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
            this.txtcodigo = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.Label();
            this.txtotraurl = new System.Windows.Forms.Label();
            this.urlotra = new System.Windows.Forms.MaskedTextBox();
            this.btnconfirmar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.lblcodigoactual = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtcodigo
            // 
            this.txtcodigo.AutoSize = true;
            this.txtcodigo.Location = new System.Drawing.Point(101, 80);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(139, 20);
            this.txtcodigo.TabIndex = 0;
            this.txtcodigo.Text = "Codigo del articulo";
            // 
            // txtnombre
            // 
            this.txtnombre.AutoSize = true;
            this.txtnombre.Location = new System.Drawing.Point(101, 129);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(65, 20);
            this.txtnombre.TabIndex = 1;
            this.txtnombre.Text = "Nombre";
            // 
            // txtotraurl
            // 
            this.txtotraurl.AutoSize = true;
            this.txtotraurl.Location = new System.Drawing.Point(101, 177);
            this.txtotraurl.Name = "txtotraurl";
            this.txtotraurl.Size = new System.Drawing.Size(130, 20);
            this.txtotraurl.TabIndex = 4;
            this.txtotraurl.Text = "Agregar imagen :";
            // 
            // urlotra
            // 
            this.urlotra.Location = new System.Drawing.Point(268, 171);
            this.urlotra.Name = "urlotra";
            this.urlotra.Size = new System.Drawing.Size(338, 26);
            this.urlotra.TabIndex = 5;
            // 
            // btnconfirmar
            // 
            this.btnconfirmar.Location = new System.Drawing.Point(96, 222);
            this.btnconfirmar.Name = "btnconfirmar";
            this.btnconfirmar.Size = new System.Drawing.Size(177, 54);
            this.btnconfirmar.TabIndex = 6;
            this.btnconfirmar.Text = "Agregar";
            this.btnconfirmar.UseVisualStyleBackColor = true;
            this.btnconfirmar.Click += new System.EventHandler(this.btnconfirmar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(429, 222);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(177, 54);
            this.btncancelar.TabIndex = 7;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // lblcodigoactual
            // 
            this.lblcodigoactual.AutoSize = true;
            this.lblcodigoactual.Location = new System.Drawing.Point(279, 80);
            this.lblcodigoactual.Name = "lblcodigoactual";
            this.lblcodigoactual.Size = new System.Drawing.Size(0, 20);
            this.lblcodigoactual.TabIndex = 8;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(279, 129);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(51, 20);
            this.lblnombre.TabIndex = 9;
            this.lblnombre.Text = "label1";
            // 
            // txtid
            // 
            this.txtid.AutoSize = true;
            this.txtid.Location = new System.Drawing.Point(101, 30);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(80, 20);
            this.txtid.TabIndex = 10;
            this.txtid.Text = "Id Articulo";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(279, 30);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(51, 20);
            this.lblid.TabIndex = 11;
            this.lblid.Text = "label1";
            // 
            // frmAgregarimagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 288);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lblcodigoactual);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnconfirmar);
            this.Controls.Add(this.urlotra);
            this.Controls.Add(this.txtotraurl);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtcodigo);
            this.Name = "frmAgregarimagen";
            this.Text = "Agregar_imagen";
            this.Load += new System.EventHandler(this.frmAgregarimagen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtcodigo;
        private System.Windows.Forms.Label txtnombre;
        private System.Windows.Forms.Label txtotraurl;
        private System.Windows.Forms.MaskedTextBox urlotra;
        private System.Windows.Forms.Button btnconfirmar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label lblcodigoactual;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label txtid;
        private System.Windows.Forms.Label lblid;
    }
}