namespace Trabajo_Practico_N2
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.txtmenu = new System.Windows.Forms.Label();
            this.btnlistar = new System.Windows.Forms.Button();
            this.btnagregararticulo = new System.Windows.Forms.Button();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.btnMarca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtmenu
            // 
            this.txtmenu.AutoSize = true;
            this.txtmenu.BackColor = System.Drawing.Color.Transparent;
            this.txtmenu.Font = new System.Drawing.Font("Impact", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmenu.ForeColor = System.Drawing.Color.DarkOrange;
            this.txtmenu.Location = new System.Drawing.Point(319, 9);
            this.txtmenu.Name = "txtmenu";
            this.txtmenu.Size = new System.Drawing.Size(157, 68);
            this.txtmenu.TabIndex = 0;
            this.txtmenu.Text = "MENU";
            // 
            // btnlistar
            // 
            this.btnlistar.BackColor = System.Drawing.Color.Transparent;
            this.btnlistar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlistar.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlistar.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnlistar.Location = new System.Drawing.Point(254, 100);
            this.btnlistar.Name = "btnlistar";
            this.btnlistar.Size = new System.Drawing.Size(276, 82);
            this.btnlistar.TabIndex = 1;
            this.btnlistar.Text = "LISTA DE ARTICULOS";
            this.btnlistar.UseVisualStyleBackColor = false;
            this.btnlistar.Click += new System.EventHandler(this.btnlistar_Click);
            // 
            // btnagregararticulo
            // 
            this.btnagregararticulo.BackColor = System.Drawing.Color.Transparent;
            this.btnagregararticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregararticulo.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregararticulo.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnagregararticulo.Location = new System.Drawing.Point(254, 223);
            this.btnagregararticulo.Name = "btnagregararticulo";
            this.btnagregararticulo.Size = new System.Drawing.Size(276, 82);
            this.btnagregararticulo.TabIndex = 3;
            this.btnagregararticulo.Text = "AGREGAR ARTICULO";
            this.btnagregararticulo.UseVisualStyleBackColor = false;
            this.btnagregararticulo.Click += new System.EventHandler(this.btnagregararticulo_Click);
            // 
            // btnCategoria
            // 
            this.btnCategoria.BackColor = System.Drawing.Color.Transparent;
            this.btnCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoria.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoria.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnCategoria.Location = new System.Drawing.Point(254, 354);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(276, 82);
            this.btnCategoria.TabIndex = 7;
            this.btnCategoria.Text = "Categorias";
            this.btnCategoria.UseVisualStyleBackColor = false;
            this.btnCategoria.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMarca
            // 
            this.btnMarca.BackColor = System.Drawing.Color.Transparent;
            this.btnMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarca.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarca.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnMarca.Location = new System.Drawing.Point(254, 474);
            this.btnMarca.Name = "btnMarca";
            this.btnMarca.Size = new System.Drawing.Size(276, 82);
            this.btnMarca.TabIndex = 8;
            this.btnMarca.Text = "Marcas";
            this.btnMarca.UseVisualStyleBackColor = false;
            this.btnMarca.Click += new System.EventHandler(this.btnMarca_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(759, 605);
            this.Controls.Add(this.btnMarca);
            this.Controls.Add(this.btnCategoria);
            this.Controls.Add(this.btnagregararticulo);
            this.Controls.Add(this.btnlistar);
            this.Controls.Add(this.txtmenu);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtmenu;
        private System.Windows.Forms.Button btnlistar;
        private System.Windows.Forms.Button btnagregararticulo;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.Button btnMarca;
    }
}