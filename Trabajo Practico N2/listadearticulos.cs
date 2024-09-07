
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
        public listadearticulos()
        {
            InitializeComponent();
            this.Load += new EventHandler(dgvArticulos_load);
        }

        private void dgvArticulos_load(object sender,EventArgs e)
        {   
            registrodearticulos registrodearticulos = new registrodearticulos();
            List<Articulo> articulos = registrodearticulos.listar();
            if (articulos.Count > 0)
            {
                dgvarticulos.DataSource = articulos;
            }
            else
            {
                MessageBox.Show("No se encontraron artículos.");
            }
        }

    
    }
}
