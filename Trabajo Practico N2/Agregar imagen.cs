using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_Practico_N2
{
    public partial class frmAgregarimagen : Form
    {
        public frmAgregarimagen()
        {
            InitializeComponent();
        }
        private Articulo articuloActual = null;
        public frmAgregarimagen(Articulo articulo)
        {
            InitializeComponent();
            this.articuloActual = articulo;
            Cargarotra(articuloActual);

        }
        private void Cargarotra(Articulo articulo)
        { int idarticulo = articulo.Id;

            if (articulo.Id != null)
            {
                lblid.Text = articulo.Id.ToString();

                lblcodigoactual.Text = articulo.codigo_de_articulo;
                lblnombre.Text = articulo.Nombre;
            }
        }

        private void frmAgregarimagen_Load(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                ImagenesNegocio otra = new ImagenesNegocio();
                Imagen imagen = new Imagen();

                imagen.url = urlotra.Text;
                if (int.TryParse(lblid.Text, out int idArticulo))
                {
                    imagen.Articulo = idArticulo;
                    otra.agregar(imagen);
                }
                else
                {
                    MessageBox.Show("El ID del artículo no es válido.");
                }

                MessageBox.Show("imagen agregada exitosamente.");

                Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el artículo: " + ex.Message);
            } 
        }
    } 
}
