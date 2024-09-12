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
        public frmVentanaDetalleArticulo(Articulo articulo)
        {
            InitializeComponent();
            Cargar(articulo);
        }

        private void frmVentanaDetalleArticulo_Load(object sender, EventArgs e)
        {

        }

        private void Cargar(Articulo articulo)
        {
            if(articulo.Id != null)
            {
                lblCodigoArticulo.Text = articulo.codigo_de_articulo;
                lblNombreArticulo.Text = articulo.Nombre;
                lblMarcaArticulo.Text = articulo.Marca.ToString();
                lblCategoriaArticulo.Text = articulo.Categoria.ToString();
                lblPrecioArticulo.Text = articulo.Precio.ToString();
                lblDescripcionArticulo.Text = articulo.Descripcion;
                cargarImagenUrl(articulo.imagen.url);
            }
        }

        private void cargarImagenUrl(string img)
        {
            try
            {
                ptbImagenDetalle.Load(img);
            }
            catch (Exception)
            {

                ptbImagenDetalle.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQNK7-n-r_w_qCEIjsnu8VXMBamUkSmLUr9Eg&s");
            }
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
