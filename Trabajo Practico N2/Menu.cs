﻿using System;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnlistar_Click(object sender, EventArgs e)
        {
            listadearticulos listadearticulos = new listadearticulos();
            listadearticulos.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmListadoCategoria listadoCategoria = new frmListadoCategoria();
            listadoCategoria.ShowDialog();
        }

        private void btnMarca_Click(object sender, EventArgs e)
        {
            frmListadoMarcas listadoMarcas = new frmListadoMarcas();
            listadoMarcas.ShowDialog();
        }

        private void btnagregararticulo_Click(object sender, EventArgs e)
        {
            frmAgregarArticulo alta = new frmAgregarArticulo();
            alta.ShowDialog();
        }
    }
}
