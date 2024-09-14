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
            this.btnBuscarMarca = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnBuscarCategoria = new System.Windows.Forms.Button();
            this.btnBuscarCodigo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBuscarMarca
            // 
            this.btnBuscarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarMarca.Location = new System.Drawing.Point(47, 102);
            this.btnBuscarMarca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscarMarca.Name = "btnBuscarMarca";
            this.btnBuscarMarca.Size = new System.Drawing.Size(159, 69);
            this.btnBuscarMarca.TabIndex = 0;
            this.btnBuscarMarca.Text = "Buscar por marca";
            this.btnBuscarMarca.UseVisualStyleBackColor = true;
            this.btnBuscarMarca.Click += new System.EventHandler(this.btnMarcaSubMenu_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblTitulo.Location = new System.Drawing.Point(202, 28);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(197, 31);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Buscar Articulo";
            // 
            // btnBuscarCategoria
            // 
            this.btnBuscarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCategoria.Location = new System.Drawing.Point(47, 213);
            this.btnBuscarCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarCategoria.Name = "btnBuscarCategoria";
            this.btnBuscarCategoria.Size = new System.Drawing.Size(159, 69);
            this.btnBuscarCategoria.TabIndex = 3;
            this.btnBuscarCategoria.Text = "Buscar por categoria";
            this.btnBuscarCategoria.UseVisualStyleBackColor = true;
            // 
            // btnBuscarCodigo
            // 
            this.btnBuscarCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCodigo.Location = new System.Drawing.Point(343, 102);
            this.btnBuscarCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarCodigo.Name = "btnBuscarCodigo";
            this.btnBuscarCodigo.Size = new System.Drawing.Size(159, 69);
            this.btnBuscarCodigo.TabIndex = 4;
            this.btnBuscarCodigo.Text = "Buscar por codigo";
            this.btnBuscarCodigo.UseVisualStyleBackColor = true;
            // 
            // frmVentanaBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnBuscarCodigo);
            this.Controls.Add(this.btnBuscarCategoria);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnBuscarMarca);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmVentanaBusqueda";
            this.Text = "Buscar Articulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarMarca;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnBuscarCategoria;
        private System.Windows.Forms.Button btnBuscarCodigo;
    }
}