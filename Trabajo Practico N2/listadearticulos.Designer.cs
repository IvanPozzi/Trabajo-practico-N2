﻿namespace Trabajo_Practico_N2
{
    partial class listadearticulos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listadearticulos));
            this.dgvarticulos = new System.Windows.Forms.DataGridView();
            this.ptbimagen = new System.Windows.Forms.PictureBox();
            this.txtimagen = new System.Windows.Forms.Label();
            this.articuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnVerDetalles = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvarticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbimagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvarticulos
            // 
            this.dgvarticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvarticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvarticulos.Location = new System.Drawing.Point(52, 12);
            this.dgvarticulos.MultiSelect = false;
            this.dgvarticulos.Name = "dgvarticulos";
            this.dgvarticulos.RowHeadersWidth = 62;
            this.dgvarticulos.RowTemplate.Height = 28;
            this.dgvarticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvarticulos.Size = new System.Drawing.Size(783, 440);
            this.dgvarticulos.TabIndex = 0;
            this.dgvarticulos.SelectionChanged += new System.EventHandler(this.dgvarticulos_SelectionChanged);
            // 
            // ptbimagen
            // 
            this.ptbimagen.Location = new System.Drawing.Point(861, 65);
            this.ptbimagen.Name = "ptbimagen";
            this.ptbimagen.Size = new System.Drawing.Size(318, 289);
            this.ptbimagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbimagen.TabIndex = 1;
            this.ptbimagen.TabStop = false;
            this.ptbimagen.Click += new System.EventHandler(this.dgvArticulos_load);
            // 
            // txtimagen
            // 
            this.txtimagen.AutoSize = true;
            this.txtimagen.BackColor = System.Drawing.Color.Transparent;
            this.txtimagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtimagen.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtimagen.ForeColor = System.Drawing.Color.Orange;
            this.txtimagen.Location = new System.Drawing.Point(927, 14);
            this.txtimagen.Name = "txtimagen";
            this.txtimagen.Size = new System.Drawing.Size(184, 25);
            this.txtimagen.TabIndex = 2;
            this.txtimagen.Text = "IMAGEN DEL ARTICULO";
            // 
            // articuloBindingSource
            // 
            this.articuloBindingSource.DataSource = typeof(Trabajo_Practico_N2.Articulo);
            // 
            // btnVerDetalles
            // 
            this.btnVerDetalles.Location = new System.Drawing.Point(52, 488);
            this.btnVerDetalles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVerDetalles.Name = "btnVerDetalles";
            this.btnVerDetalles.Size = new System.Drawing.Size(130, 45);
            this.btnVerDetalles.TabIndex = 3;
            this.btnVerDetalles.Text = "Detalles";
            this.btnVerDetalles.UseVisualStyleBackColor = true;
            this.btnVerDetalles.Click += new System.EventHandler(this.btnVerDetalles_Click);
            // 
            // listadearticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1208, 551);
            this.Controls.Add(this.btnVerDetalles);
            this.Controls.Add(this.txtimagen);
            this.Controls.Add(this.ptbimagen);
            this.Controls.Add(this.dgvarticulos);
            this.Name = "listadearticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "listadearticulos";
            this.Load += new System.EventHandler(this.listadearticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvarticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbimagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource articuloBindingSource;
        private System.Windows.Forms.DataGridView dgvarticulos;
        private System.Windows.Forms.PictureBox ptbimagen;
        private System.Windows.Forms.Label txtimagen;
        private System.Windows.Forms.Button btnVerDetalles;
    }
}