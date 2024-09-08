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
    public partial class frmMenuCategorias : Form
    {
        public frmMenuCategorias()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            frmListadoCategoria listadoCategoria = new frmListadoCategoria();
            listadoCategoria.ShowDialog();
        }
    }
}
