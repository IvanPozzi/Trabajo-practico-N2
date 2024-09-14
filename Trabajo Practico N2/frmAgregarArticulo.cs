using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;


namespace Trabajo_Practico_N2
{
    public partial class frmAgregarArticulo : Form
    {
        Articulo articulo = null;
        public frmAgregarArticulo()
        {
            InitializeComponent();
        }

        public frmAgregarArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            lblAgregarArticuloTitulo.Text = "Modificar Articulo";
            Text = "Modificar articulo";
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }



        /*private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(this.articulo == null)
            {
                articulo = new Articulo();
            }
            



            Articulonegocio negocio = new Articulonegocio();
            Imagen imagen = new Imagen();
            ImagenesNegocio nuevaimagen = new ImagenesNegocio();

            try
            {
                articulo.codigo_de_articulo = txtcadigo.Text;
                articulo.Nombre = txtnombre.Text;   
                articulo.Descripcion = txtdescripcion.Text;

                articulo.Categoria = (int)cmbcategoria.SelectedValue;
                articulo.Marca = (int)cmbmarca.SelectedValue;
                articulo.Precio = float.Parse(txtprecio.Text);


                imagen.url=txturl.Text;
                imagen.Id = articulo.imagen.Id;

                //articulo.imagen.url=txturl.Text; 
                

                if (articulo.Id == 0)
                {
                    negocio.agregar(articulo);
                    if(imagen.ToString() != "")
                    {
                        imagen.Articulo =  (int)negocio.buscarPorCodigo(articulo.codigo_de_articulo); //se busca el id del articulo para 
                        nuevaimagen.agregar(imagen);
                    }
                }
                else
                {
                    if(imagen.url != "" && imagen.ToString() != null)
                    {
                        if(imagen.Id == 0)
                        {
                            imagen.Articulo = articulo.Id;
                            nuevaimagen.agregar(imagen);
                        }
                        else
                        { 
                            nuevaimagen.modificar(imagen);
                        }
                        

                    }
                    negocio.modificar(articulo);
                }

                MessageBox.Show("Artículo agregado exitosamente.");

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el artículo: " + ex.Message);
            }

        }

        private void frmAgregarArticulo_Load(object sender, EventArgs e)
        {
            CargarCombo cargarCombo = new CargarCombo();


            cargarCombo.cargarCategorias(cmbcategoria);
            cargarCombo.cargarMarcas(cmbmarca);

            if (articulo != null)
            {
                try
                {
                    txtcadigo.Text = articulo.codigo_de_articulo;
                    txtnombre.Text = articulo.Nombre;
                    txtdescripcion.Text = articulo.Descripcion;

                    cmbcategoria.SelectedValue = articulo.Categoria;
                    cmbmarca.SelectedValue = articulo.Marca;
                    
                    txtprecio.Text = articulo.Precio.ToString();
                    txturl.Text = articulo.imagen.url;

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }

            

        }*/
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.articulo == null)
            {
                articulo = new Articulo();
            }

            Articulonegocio negocio = new Articulonegocio();
            Imagen imagen = new Imagen();
            ImagenesNegocio nuevaimagen = new ImagenesNegocio();

            try
            {
                articulo.codigo_de_articulo = txtcadigo.Text;
                articulo.Nombre = txtnombre.Text;
                articulo.Descripcion = txtdescripcion.Text;

                articulo.Categoria = (int)cmbcategoria.SelectedValue;
                articulo.Marca = (int)cmbmarca.SelectedValue;
                articulo.Precio = float.Parse(txtprecio.Text);

                if (articulo.imagen == null)
                {
                    articulo.imagen = new Imagen();
                }

                imagen.url = txturl.Text;

                if (articulo.Id == 0)
                {
                    negocio.agregar(articulo);

                    if (!string.IsNullOrWhiteSpace(imagen.url))
                    {
                        imagen.Articulo = (int)negocio.buscarPorCodigo(articulo.codigo_de_articulo); // Se busca el id del articulo para
                        nuevaimagen.agregar(imagen);
                    }
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(imagen.url))
                    {
                        if (imagen.Id == 0)
                        {
                            imagen.Articulo = articulo.Id;
                            nuevaimagen.agregar(imagen);
                        }
                        else
                        {
                            nuevaimagen.modificar(imagen);
                        }
                    }

                    negocio.modificar(articulo);
                }

                MessageBox.Show("Artículo agregado exitosamente.");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el artículo: " + ex.Message);
            }
        }

        private void frmAgregarArticulo_Load(object sender, EventArgs e)
        {
            CargarCombo cargarCombo = new CargarCombo();

            cargarCombo.cargarCategorias(cmbcategoria);
            cargarCombo.cargarMarcas(cmbmarca);

            if (articulo != null)
            {
                try
                {
                    txtcadigo.Text = articulo.codigo_de_articulo;
                    txtnombre.Text = articulo.Nombre;
                    txtdescripcion.Text = articulo.Descripcion;

                    cmbcategoria.SelectedValue = articulo.Categoria;
                    cmbmarca.SelectedValue = articulo.Marca;

                    txtprecio.Text = articulo.Precio.ToString();
                    txturl.Text = articulo.imagen.url ?? ""; 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar el artículo: " + ex.Message);
                }
            }
        }

        private void LimpiarCampos()
        {
            txtcadigo.Clear();
            txtnombre.Clear();
            txtdescripcion.Clear();
            txtprecio.Clear();

           //esto limpia los campos de las ventanas para agregar otro articulo nuevo
            cmbcategoria.SelectedIndex = -1;
            cmbmarca.SelectedIndex = -1;

            // te posiciona de nuevo en el primer campo
            txtcadigo.Focus();
        }
    }
}
