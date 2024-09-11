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
    public partial class frmListadoMarcas : Form
    {
        public frmListadoMarcas()
        {
            InitializeComponent();
        }

        private void frmListadoMarcas_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Cargar()
        {
            MarcaNegocio negocio = new MarcaNegocio();
            dgvMarcas.DataSource = negocio.listar();

            //Ocultar la columna Id
            dgvMarcas.Columns["Id"].Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarMarcas formAgregar = new frmAgregarMarcas();
            formAgregar.ShowDialog();
            Cargar();
        }


        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            Marca seleccionado;
            seleccionado = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
            frmAgregarMarcas formModificar = new frmAgregarMarcas(seleccionado);
            formModificar.ShowDialog();
            Cargar();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            Marca seleccionado;
            try
            {
                DialogResult resultado = MessageBox.Show("¿Seguro que quiere eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    seleccionado = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                    MessageBox.Show("Eliminado exitosamente");
                    Cargar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
