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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Ventana1 ventanaagregar = new Ventana1();
            ventanaagregar.ShowDialog();  
        }

        private void btnverdetalle_Click(object sender, EventArgs e)
        {
            frmVentanaDetalleArticulo ventana = new frmVentanaDetalleArticulo();
            ventana.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmVentanaEliminarArticulo ventana = new frmVentanaEliminarArticulo();
            ventana.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmVentanaBusqueda ventana = new frmVentanaBusqueda();
            ventana.ShowDialog();
        }
    }
}
