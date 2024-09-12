
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
    public partial class listadearticulos : Form
    {
        private List<Articulo> listaarticu;
        public listadearticulos()
        {
            InitializeComponent();
            this.Load += new EventHandler(dgvArticulos_load);
        }

        private void dgvArticulos_load(object sender,EventArgs e)
        {   
            Articulonegocio registrodearticulos = new Articulonegocio();
            listaarticu = registrodearticulos.listar(); 
            dgvarticulos.DataSource = listaarticu;

            try
            {
                ptbimagen.Load(listaarticu[0].imagen.url);
            }
            catch (Exception ex)
            {
                ptbimagen.Load("https://www.smarttools.com.mx/wp-content/uploads/2019/05/imagen-no-disponible.png");

            }
         
        }

   

        private void dgvarticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvarticulos.CurrentRow.DataBoundItem;
            try
            {
               
                ptbimagen.Load(seleccionado.imagen.url);
            }
            catch (Exception ex)
            {
                ptbimagen.Load(seleccionado.imagen.imgNoEncontrada()); ;

            }

        }

        private void listadearticulos_Load(object sender, EventArgs e)
        {

        }

        private void btnVerDetalles_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvarticulos.CurrentRow.DataBoundItem;
            frmVentanaDetalleArticulo detalleArticulo = new frmVentanaDetalleArticulo(seleccionado);
            detalleArticulo.ShowDialog();
        }

    }
}
