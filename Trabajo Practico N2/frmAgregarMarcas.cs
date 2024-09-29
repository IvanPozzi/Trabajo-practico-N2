using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Trabajo_Practico_N2
{
    public partial class frmAgregarMarcas : Form
    {
        Marca marca = null;
        public frmAgregarMarcas()
        {
            InitializeComponent();
        }

        public frmAgregarMarcas(Marca marca)
        {
            InitializeComponent();
            this.marca = marca;
            Text = "Modificar Marca";
        }

        private void frmAgregarMarcas_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.marca != null)
                {
                    lblTitulo.Text = "Modificar Marca";
                    txtCategoria.Text = marca.Descripcion.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();

            try
            {
                if (marca == null)
                {
                    marca = new Marca();
                }
                marca.Descripcion = txtCategoria.Text;

                if (marca.Id != 0)
                {
                    negocio.modificar(marca);
                }
                else
                {
                    negocio.agregar(marca);
                }

                MessageBox.Show("Agregado exitosamente");
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
    }
}
