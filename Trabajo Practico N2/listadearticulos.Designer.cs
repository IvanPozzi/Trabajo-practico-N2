namespace Trabajo_Practico_N2
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
            this.btnVerDetalles = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnagregarimagen = new System.Windows.Forms.Button();
            this.btnImagenAnterior = new System.Windows.Forms.Button();
            this.btnImagenSiguiente = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblfiltro = new System.Windows.Forms.Label();
            this.txtbuscador = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.articuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvarticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbimagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvarticulos
            // 
            this.dgvarticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvarticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvarticulos.Location = new System.Drawing.Point(36, 22);
            this.dgvarticulos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvarticulos.MultiSelect = false;
            this.dgvarticulos.Name = "dgvarticulos";
            this.dgvarticulos.RowHeadersWidth = 62;
            this.dgvarticulos.RowTemplate.Height = 28;
            this.dgvarticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvarticulos.Size = new System.Drawing.Size(783, 378);
            this.dgvarticulos.TabIndex = 0;
            this.dgvarticulos.SelectionChanged += new System.EventHandler(this.dgvarticulos_SelectionChanged);
            // 
            // ptbimagen
            // 
            this.ptbimagen.Location = new System.Drawing.Point(935, 22);
            this.ptbimagen.Margin = new System.Windows.Forms.Padding(2);
            this.ptbimagen.Name = "ptbimagen";
            this.ptbimagen.Size = new System.Drawing.Size(398, 357);
            this.ptbimagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbimagen.TabIndex = 1;
            this.ptbimagen.TabStop = false;
            this.ptbimagen.Click += new System.EventHandler(this.dgvArticulos_load);
            // 
            // btnVerDetalles
            // 
            this.btnVerDetalles.Location = new System.Drawing.Point(37, 464);
            this.btnVerDetalles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVerDetalles.Name = "btnVerDetalles";
            this.btnVerDetalles.Size = new System.Drawing.Size(146, 36);
            this.btnVerDetalles.TabIndex = 3;
            this.btnVerDetalles.Text = "Detalles";
            this.btnVerDetalles.UseVisualStyleBackColor = true;
            this.btnVerDetalles.Click += new System.EventHandler(this.btnVerDetalles_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(233, 467);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(144, 33);
            this.btneliminar.TabIndex = 4;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(415, 466);
            this.btnmodificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(143, 33);
            this.btnmodificar.TabIndex = 5;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnagregarimagen
            // 
            this.btnagregarimagen.Location = new System.Drawing.Point(1050, 465);
            this.btnagregarimagen.Margin = new System.Windows.Forms.Padding(2);
            this.btnagregarimagen.Name = "btnagregarimagen";
            this.btnagregarimagen.Size = new System.Drawing.Size(143, 34);
            this.btnagregarimagen.TabIndex = 6;
            this.btnagregarimagen.Text = "Agregar imagan";
            this.btnagregarimagen.UseVisualStyleBackColor = true;
            this.btnagregarimagen.Click += new System.EventHandler(this.btnagregarimagen_Click);
            // 
            // btnImagenAnterior
            // 
            this.btnImagenAnterior.Location = new System.Drawing.Point(1039, 430);
            this.btnImagenAnterior.Margin = new System.Windows.Forms.Padding(2);
            this.btnImagenAnterior.Name = "btnImagenAnterior";
            this.btnImagenAnterior.Size = new System.Drawing.Size(68, 32);
            this.btnImagenAnterior.TabIndex = 7;
            this.btnImagenAnterior.Text = "Anterior";
            this.btnImagenAnterior.UseVisualStyleBackColor = true;
            this.btnImagenAnterior.Click += new System.EventHandler(this.btnImagenAnterior_Click_1);
            // 
            // btnImagenSiguiente
            // 
            this.btnImagenSiguiente.Location = new System.Drawing.Point(1136, 429);
            this.btnImagenSiguiente.Margin = new System.Windows.Forms.Padding(2);
            this.btnImagenSiguiente.Name = "btnImagenSiguiente";
            this.btnImagenSiguiente.Size = new System.Drawing.Size(65, 32);
            this.btnImagenSiguiente.TabIndex = 8;
            this.btnImagenSiguiente.Text = "Siguiente";
            this.btnImagenSiguiente.UseVisualStyleBackColor = true;
            this.btnImagenSiguiente.Click += new System.EventHandler(this.btnImagenSiguiente_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            // 
            // lblfiltro
            // 
            this.lblfiltro.AutoSize = true;
            this.lblfiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfiltro.Location = new System.Drawing.Point(33, 426);
            this.lblfiltro.Name = "lblfiltro";
            this.lblfiltro.Size = new System.Drawing.Size(61, 24);
            this.lblfiltro.TabIndex = 9;
            this.lblfiltro.Text = "Filtro :";
            // 
            // txtbuscador
            // 
            this.txtbuscador.Location = new System.Drawing.Point(100, 426);
            this.txtbuscador.Name = "txtbuscador";
            this.txtbuscador.Size = new System.Drawing.Size(373, 20);
            this.txtbuscador.TabIndex = 10;
            this.txtbuscador.TextChanged += new System.EventHandler(this.txtbuscador_TextChanged);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(604, 408);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(215, 54);
            this.btnbuscar.TabIndex = 11;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            // 
            // articuloBindingSource
            // 
            // 
            // listadearticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1400, 522);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtbuscador);
            this.Controls.Add(this.lblfiltro);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnImagenSiguiente);
            this.Controls.Add(this.btnImagenAnterior);
            this.Controls.Add(this.btnagregarimagen);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnVerDetalles);
            this.Controls.Add(this.ptbimagen);
            this.Controls.Add(this.dgvarticulos);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "listadearticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "listadearticulos";
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
        private System.Windows.Forms.Button btnVerDetalles;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnagregarimagen;
        private System.Windows.Forms.Button btnImagenAnterior;
        private System.Windows.Forms.Button btnImagenSiguiente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblfiltro;
        private System.Windows.Forms.TextBox txtbuscador;
        private System.Windows.Forms.Button btnbuscar;
    }
}