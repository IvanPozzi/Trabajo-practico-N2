﻿
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
            if (dgvarticulos.CurrentRow != null)
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

        }
        private void Cargar()
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

        private void listadearticulos_Load(object sender, EventArgs e)
        {

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

        private void dgvarticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void btnbuscar_Click(object sender, EventArgs e)
        {
     
        }
        public void ocultarcolumnas()
        {
            dgvarticulos.Columns["Marca"].Visible = false;
            dgvarticulos.Columns["Categoria"].Visible = false;
            
        }

        private void txtbuscador_KeyPress(object sender, KeyPressEventArgs e)
        {
            List<Articulo> filtrada;
            string filtro = txtbuscador.Text;

            if (filtro.Length>=2)
            {
                filtrada = listaarticu.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.descripcionMarca.ToUpper().Contains(filtro.ToUpper()));

            }
            else
            {

                filtrada = listaarticu;

            }
            dgvarticulos.DataSource = null;
            dgvarticulos.DataSource = filtrada;
            ocultarcolumnas();
        }
    }
}
