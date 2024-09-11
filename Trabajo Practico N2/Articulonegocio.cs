using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_N2
{
    public class Articulonegocio
    {

        /*public List<Articulo> listar()
        {
            List<Articulo> listaArticulo = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();


            try
            {
                datos.setearConsulta(@"SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, A.IdMarca, A.IdCategoria, A.Precio,I.ImagenUrl FROM ARTICULOS A  LEFT JOIN IMAGENES I ON A.Id = I.IdArticulo");//("SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, A.IdMarca, A.IdCategoria, A.Precio, I.IdArticulo, I.ImagenUrl FROM ARTICULOS A,IMAGENES I WHERE A.Id = I.IdArticulo");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {   Articulo aux = new Articulo();
                    aux.Id = datos.Lector.GetInt32(0);
                    aux.codigo_de_articulo = datos.Lector.GetString(1);
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca = (int)datos.Lector["IdMarca"];
                    aux.Categoria = (int)datos.Lector["IdCategoria"];
                    aux.Precio = (float)(decimal)datos.Lector["Precio"];
                    aux.imagen = new Imagen();
                    aux.imagen.url = (string)datos.Lector["ImagenUrl"];

   

                    listaArticulo.Add(aux);
                }
                datos.cerrarConexion();
                return listaArticulo;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }*/

        public List<Articulo> listar()
        {
            List<Articulo> listaArticulo = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta(@"SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, A.IdMarca, A.IdCategoria, A.Precio,I.ImagenUrl 
                               FROM ARTICULOS A
                               LEFT JOIN IMAGENES I ON A.Id = I.IdArticulo");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = datos.Lector.GetInt32(0);
                    aux.codigo_de_articulo = datos.Lector.GetString(1);
                    aux.Nombre = datos.Lector.GetString(2); 
                    aux.Descripcion = datos.Lector.GetString(3); 
                    aux.Marca = datos.Lector.GetInt32(4); 
                    aux.Categoria = datos.Lector.GetInt32(5);
                    aux.Precio = (float)(decimal)datos.Lector["Precio"]; 

                    
                    if (!datos.Lector.IsDBNull(7)) 
                    {
                        aux.imagen = new Imagen();
                        aux.imagen.url = datos.Lector.GetString(7);
                    }
                    else
                    {
                        aux.imagen = null; 
                    }

                    listaArticulo.Add(aux);
                }

                datos.cerrarConexion();
                return listaArticulo;
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


        public void agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                string consulta = "Insert Into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) " +
                                  "values (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @Precio)";
                datos.setearConsulta(consulta);
                datos.setearParametro("@Codigo", nuevo.codigo_de_articulo);
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@Descripcion", nuevo.Descripcion);
                datos.setearParametro("@IdMarca", nuevo.Marca);
                datos.setearParametro("@IdCategoria", nuevo.Categoria);
                datos.setearParametro("@Precio", nuevo.Precio);
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


        public void modificar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                string consulta = "update ARTICULOS set Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, " +
                                  "IdMarca = @IdMarca, IdCategoria = @IdCategoria, Precio = @Precio where Id = @Id";
                datos.setearConsulta(consulta);
                datos.setearParametro("@Codigo", articulo.codigo_de_articulo);
                datos.setearParametro("@Nombre", articulo.Nombre);
                datos.setearParametro("@Descripcion", articulo.Descripcion);
                datos.setearParametro("@IdMarca", articulo.Marca);
                datos.setearParametro("@IdCategoria", articulo.Categoria);
                datos.setearParametro("@Precio", articulo.Precio);
                datos.setearParametro("@Id", articulo.Id);

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


        public void eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("delete from ARTICULOS where Id = @Id");
                datos.setearParametro("@Id", id);
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
