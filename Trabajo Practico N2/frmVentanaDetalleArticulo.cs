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
    public partial class frmVentanaDetalleArticulo : Form
    {
        private Articulo articuloActual = null;
        
        public frmVentanaDetalleArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articuloActual = articulo;
            Cargar(articuloActual);
        }

        private void frmVentanaDetalleArticulo_Load(object sender, EventArgs e)
        {

        }

        public void Cargar(Articulo articulo)
        {
            if(articulo.Id != null)
            {
                lblCodigoArticulo.Text = articulo.Codigo;
                lblNombreArticulo.Text = articulo.Nombre;
                lblMarcaArticulo.Text = articulo.Marca;
                lblCategoriaArticulo.Text = articulo.Categoria;
                lblPrecioArticulo.Text = articulo.Precio.ToString();
                lblDescripcionArticulo.Text = articulo.Descripcion;

                try
                {
                    ptbImagenDetalle.Load(articulo.Imagen[0].url);
                }
                catch (Exception)
                {

                    ptbImagenDetalle.Load(articulo.Imagen[0].imgNoEncontrada());
                }
                
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void btnModificar_Click(object sender, EventArgs e)
        {
            
            
            frmAgregarArticulo modificarArticulo = new frmAgregarArticulo(articuloActual);
            modificarArticulo.ShowDialog();
        }
    }
}
