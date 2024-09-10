using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


using System.Windows.Forms;

namespace Trabajo_Practico_N2
{
    public class registrodearticulos
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS;database=CATALOGO_P3_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, A.IdMarca, A.IdCategoria, A.Precio, I.IdArticulo, I.ImagenUrl FROM ARTICULOS A,IMAGENES I WHERE A.Id = I.IdArticulo";//"SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, A.IdMarca, A.IdCategoria, A.Precio, I.IdArticulo,I.ImagenUrl FROM ARTICULOS A,IMAGENES I WHERE A.Id = I.IdArticulo;";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();


                // Obtén el índice de la columna ImagenUrl usando GetOrdinal
                int imagenUrlIndex = lector.GetOrdinal("ImagenUrl");


                while (lector.Read())
                {
                    Articulo aux = new Articulo();

                    aux.Id = lector.GetInt32(0);
                    aux.codigo_de_articulo = lector.GetString(1);
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.Marca = (int)lector["IdMarca"];
                    aux.Categoria = (int)lector["IdCategoria"];
                    aux.Precio = (float)(decimal)lector["Precio"];
                    aux.imagen = new Imagen();
                    aux.imagen.url = (string)lector["ImagenUrl"];//lector.GetString(imagenUrlIndex);
                    //aux.imagen.url = lector.GetString(7);

                    //aux.imagen.url = (string)lector.GetString(2);
                    //aux.imagenurl = lector.GetString(2);

                    lista.Add(aux);
                }

                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }



        public void agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Insert Into articulo(Descripcion) values(A.Id, A.Codigo, A.Nombre, A.Descripcion, A.IdMarca, A.IdCategoria, A.Precio, I.IdArticulo)");
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}


