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
    public partial class frmAgregarCategoria : Form
    {
        Categoria categoria = null;
        public frmAgregarCategoria()
        {
            InitializeComponent();
        }

        public frmAgregarCategoria(Categoria categoria)
        {
            InitializeComponent();
            this.categoria = categoria;

        }

        private void frmAgregarCategoria_Load(object sender, EventArgs e)
        {
            try
            {
                if(this.categoria != null)
                {
                    lblTitulo.Text = "Modificar categoria";
                    txtCategoria.Text = categoria.Descripcion.ToString();

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
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {
                if(categoria == null)
                {
                    categoria = new Categoria();
                }
                categoria.Descripcion = txtCategoria.Text;

                if (categoria.Id != 0)
                {
                    negocio.modificar(categoria);
                }
                else
                {
                    negocio.agregar(categoria);
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
