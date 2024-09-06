namespace Trabajo_Practico_N2
{
    partial class frmVentanaBusqueda
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
            this.btnMarcaSubMenu = new System.Windows.Forms.Button();
            this.btnCategoriaSubMenu = new System.Windows.Forms.Button();
            this.lblCartelCriterioBusqueda = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMarcaSubMenu
            // 
            this.btnMarcaSubMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarcaSubMenu.Location = new System.Drawing.Point(274, 128);
            this.btnMarcaSubMenu.Name = "btnMarcaSubMenu";
            this.btnMarcaSubMenu.Size = new System.Drawing.Size(212, 85);
            this.btnMarcaSubMenu.TabIndex = 0;
            this.btnMarcaSubMenu.Text = "Marca";
            this.btnMarcaSubMenu.UseVisualStyleBackColor = true;
            this.btnMarcaSubMenu.Click += new System.EventHandler(this.btnMarcaSubMenu_Click);
            // 
            // btnCategoriaSubMenu
            // 
            this.btnCategoriaSubMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoriaSubMenu.Location = new System.Drawing.Point(274, 260);
            this.btnCategoriaSubMenu.Name = "btnCategoriaSubMenu";
            this.btnCategoriaSubMenu.Size = new System.Drawing.Size(212, 91);
            this.btnCategoriaSubMenu.TabIndex = 1;
            this.btnCategoriaSubMenu.Text = "Categoria";
            this.btnCategoriaSubMenu.UseVisualStyleBackColor = true;
            this.btnCategoriaSubMenu.Click += new System.EventHandler(this.btnCategoriaSubMenu_Click);
            // 
            // lblCartelCriterioBusqueda
            // 
            this.lblCartelCriterioBusqueda.AutoSize = true;
            this.lblCartelCriterioBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartelCriterioBusqueda.Location = new System.Drawing.Point(205, 45);
            this.lblCartelCriterioBusqueda.Name = "lblCartelCriterioBusqueda";
            this.lblCartelCriterioBusqueda.Size = new System.Drawing.Size(393, 25);
            this.lblCartelCriterioBusqueda.TabIndex = 2;
            this.lblCartelCriterioBusqueda.Text = "¿Por cual criterio desea hacer la búsqueda?";
            // 
            // frmVentanaBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCartelCriterioBusqueda);
            this.Controls.Add(this.btnCategoriaSubMenu);
            this.Controls.Add(this.btnMarcaSubMenu);
            this.Name = "frmVentanaBusqueda";
            this.Text = "frmVentanaBusqueda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMarcaSubMenu;
        private System.Windows.Forms.Button btnCategoriaSubMenu;
        private System.Windows.Forms.Label lblCartelCriterioBusqueda;
    }
}