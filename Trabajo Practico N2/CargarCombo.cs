using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Trabajo_Practico_N2
{
    public class CargarCombo
    {
        public void cargarCategorias(ComboBox comboBox)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT Id, Descripcion FROM CATEGORIAS");
                datos.ejecutarLectura();
                DataTable dtCategorias = new DataTable();
                dtCategorias.Load(datos.Lector);

                comboBox.DataSource = dtCategorias;
                comboBox.DisplayMember = "Descripcion"; 
                comboBox.ValueMember = "Id"; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías: " + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void cargarMarcas(ComboBox comboBox)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT Id, Descripcion FROM MARCAS");
                datos.ejecutarLectura();
                DataTable dtMarcas = new DataTable();
                dtMarcas.Load(datos.Lector);

                comboBox.DataSource = dtMarcas;
                comboBox.DisplayMember = "Descripcion"; 
                comboBox.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar marcas: " + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
