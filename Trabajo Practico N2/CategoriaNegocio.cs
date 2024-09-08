using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Trabajo_Practico_N2
{
    internal class CategoriaNegocio
    {
        public List<Categoria> listar()
        {
            List<Categoria> listaCategorias = new List<Categoria>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select Descripcion From Categorias";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read()) 
                {
                    Categoria aux = new Categoria();
                    aux.Descripcion = (string)lector["Descripcion"].ToString();

                    listaCategorias.Add(aux);
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

            return listaCategorias;
        }
    }
}
