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
    public partial class frmVentanaBusqueda : Form
    {
        public frmVentanaBusqueda()
        {
            InitializeComponent();
        }

        private void btnMarcaSubMenu_Click(object sender, EventArgs e)
        {
        
        frmVentanaBusquedaPorMarca ventana = new frmVentanaBusquedaPorMarca();
            ventana.ShowDialog();
        }

        private void btnCategoriaSubMenu_Click(object sender, EventArgs e)
        {
            frmVentanaBusquedaPorCategoria ventana = new frmVentanaBusquedaPorCategoria();
            ventana.ShowDialog();
        }
    }
}
