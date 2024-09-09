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
    public partial class frmListadoCategoria : Form
    {
        public frmListadoCategoria()
        {
            InitializeComponent();
        }

        private void frmListadoCategoria_Load(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            dgvCategorias.DataSource = negocio.listar();

            //Ocultar la columna Id
            dgvCategorias.Columns["Id"].Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarCategoria formAgregar = new frmAgregarCategoria();
            formAgregar.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Categoria seleccionado;
            seleccionado = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
            frmAgregarCategoria formModificar = new frmAgregarCategoria(seleccionado);
            formModificar.ShowDialog();
        }
    }
}
