
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
        private Articulo seleccionado;
        private int ItemImagen = 0;
        int limiteItem;
        public listadearticulos()
        {
            InitializeComponent();
            this.Load += new EventHandler(dgvArticulos_load);
        }
        public listadearticulos(Articulo articulo)
        {
            InitializeComponent();
            //this.Load += new EventHandler(dgvArticulos_load);
        }

        private void dgvArticulos_load(object sender,EventArgs e)
        {
            Articulonegocio registrodearticulos = new Articulonegocio();
            listaarticu = registrodearticulos.listar(); 
            dgvarticulos.DataSource = listaarticu;
            dgvarticulos.Columns["Id"].Visible = false;
            dgvarticulos.Columns["IdCategoria"].Visible = false;
            dgvarticulos.Columns["IdMarca"].Visible = false;
            


            try
            {
                limitarCarrousel(listaarticu[0].Imagen);
                ptbimagen.Load(listaarticu[0].Imagen[ItemImagen].url);
            }
            catch (Exception ex)
            {
                ptbimagen.Load("https://www.smarttools.com.mx/wp-content/uploads/2019/05/imagen-no-disponible.png");

            }
         
        }

   

        private void dgvarticulos_SelectionChanged(object sender, EventArgs e)
        {
            seleccionado = (Articulo)dgvarticulos.CurrentRow.DataBoundItem;
            
            try
            {
                limitarCarrousel(seleccionado.Imagen);
                ptbimagen.Load(seleccionado.Imagen[ItemImagen].url);
            }
            catch (Exception ex)
            {
                Imagen imagenPorDefecto = new Imagen();
                ptbimagen.Load(imagenPorDefecto.imgNoEncontrada());

            }

        }
        private void Cargar()
        {
            Articulonegocio registrodearticulos = new Articulonegocio();
            listaarticu = registrodearticulos.listar();
            dgvarticulos.DataSource = listaarticu;
            btnImagenAnterior.Visible = false;

            try
            {
                ptbimagen.Load(listaarticu[0].Imagen[0].url);
                limitarCarrousel(listaarticu[0].Imagen);
                ItemImagen = 0;
            }
            catch (Exception ex)
            {
                ptbimagen.Load("https://www.smarttools.com.mx/wp-content/uploads/2019/05/imagen-no-disponible.png");

            }



        }

        private void btnVerDetalles_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvarticulos.CurrentRow.DataBoundItem;
            frmVentanaDetalleArticulo detalleArticulo = new frmVentanaDetalleArticulo(seleccionado);
            detalleArticulo.ShowDialog();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            
           

            Articulonegocio negocio = new Articulonegocio();
            Articulo seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿De verdad querés eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvarticulos.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                    Cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private Articulo articuloActual = null;
        private void btnmodificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvarticulos.CurrentRow.DataBoundItem;
            //Articulo articuloActual = null;
            frmAgregarArticulo modificarArticulo = new frmAgregarArticulo(seleccionado);
            modificarArticulo.ShowDialog();
            Cargar();
       


        }

        private void btnagregarimagen_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvarticulos.CurrentRow.DataBoundItem;
            frmAgregarimagen agregar=new frmAgregarimagen(seleccionado);
            agregar.ShowDialog();
           // ImagenesNegocio nuevaimagen = new ImagenesNegocio();
            //nuevaimagen.agregarotra();
        }

        private void btnImagenSiguiente_Click(object sender, EventArgs e)
        {
            try
            {
                if (ItemImagen < limiteItem)
                {
                    ItemImagen++;
                    ptbimagen.Load(seleccionado.Imagen[ItemImagen].url);
                    btnImagenAnterior.Visible = true;

                    if (ItemImagen == limiteItem)
                    {
                        btnImagenSiguiente.Visible = false;
                    }

                }
            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void limitarCarrousel(List<Imagen> listaImagenes)
        {
            ItemImagen = 0;
            limiteItem = listaImagenes.Count()-1;
            btnImagenAnterior.Visible=false;

            if(limiteItem == 0)
            {
                btnImagenSiguiente.Visible=false;
            }
            else
            {
                btnImagenSiguiente.Visible = true;
            }
        }

        private void btnImagenAnterior_Click(object sender, EventArgs e)
        {
            try
            {
                if (ItemImagen > 0)
                {
                    ItemImagen--;
                    ptbimagen.Load(seleccionado.Imagen[ItemImagen].url);
                    btnImagenSiguiente.Visible = true;

                    if (ItemImagen == 0)
                    {
                        btnImagenAnterior.Visible = false;
                    }

                }
            }
            catch (Exception ex)
            {

                ptbimagen.Load(seleccionado.Imagen[0].imgNoEncontrada());
            }

        }
    }
}
