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
    public partial class frmAgregarArticulo : Form
    {
        public frmAgregarArticulo()
        {
            InitializeComponent();
        }
        

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Articulo nuevoArticulo = new Articulo();
            Articulonegocio negocio = new Articulonegocio();

            try
            {
                nuevoArticulo.codigo_de_articulo = txtcadigo.Text;
                nuevoArticulo.Nombre = txtnombre.Text;
                nuevoArticulo.Descripcion = txtdescripcion.Text;

                nuevoArticulo.Categoria = (int)cmbcategoria.SelectedValue;
                nuevoArticulo.Marca = (int)cmbmarca.SelectedValue;
                nuevoArticulo.Precio = float.Parse(txtprecio.Text);

                negocio.agregar(nuevoArticulo);

                MessageBox.Show("Artículo agregado exitosamente.");

                LimpiarCampos();
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
