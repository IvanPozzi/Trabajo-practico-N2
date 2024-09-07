
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
            registrodearticulos registrodearticulos = new registrodearticulos();
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
    }
}
