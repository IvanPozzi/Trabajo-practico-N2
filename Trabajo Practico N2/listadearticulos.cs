
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
        private List<Articulo> listaarticu;
        public listadearticulos()
        {
            InitializeComponent();
            this.Load += new EventHandler(dgvArticulos_load);
        }

        private void dgvArticulos_load(object sender,EventArgs e)
        {   
            Articulonegocio registrodearticulos = new Articulonegocio();
            listaarticu = registrodearticulos.listar(); 
            dgvarticulos.DataSource = listaarticu;
            ptbimagen.Load(listaarticu[0].imagen.url);
         
        }

   

        private void dgvarticulos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                Articulo seleccionado = (Articulo)dgvarticulos.CurrentRow.DataBoundItem;
                ptbimagen.Load(seleccionado.imagen.url);
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se encontro la imagen");

            }

        }

        private void dgvarticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listadearticulos_Load(object sender, EventArgs e)
        {

        }
    }
}
