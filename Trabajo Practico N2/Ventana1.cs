using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using articulo;

namespace Trabajo_Practico_N2
{
    public partial class Ventana1 : Form
    {
        public Ventana1()
        {
            InitializeComponent();
        }

        public void maskedTextBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string codigo_de_articulo=txtcodigo.Text;
            string Nombre=txtnombre.Text;   
            string Descripcion=txtdescripcion.Text; 
            string Marca=txtmarca.Text; 
            string Categoria=txtcategoria.Text;
            float Precio = (float)numericUpDown1.Value;
        }

 
    }
}
