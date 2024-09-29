using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;


namespace Negocio
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

        /*public List<Articulo> listar()
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
        }*/
        /*public List<Articulo> listar()
        {
            List<Articulo> listaArticulo = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta(@"
            SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, A.IdMarca, M.Descripcion AS MarcaDescripcion, 
                   A.IdCategoria, C.Descripcion AS CategoriaDescripcion, A.Precio, I.ImagenUrl 
            FROM ARTICULOS A
            LEFT JOIN IMAGENES I ON A.Id = I.IdArticulo
            LEFT JOIN MARCAS M ON A.IdMarca = M.Id
            LEFT JOIN CATEGORIAS C ON A.IdCategoria = C.Id");

                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = datos.Lector.GetInt32(0);
                    aux.codigo_de_articulo = datos.Lector.GetString(1);
                    aux.Nombre = datos.Lector.GetString(2);
                    aux.Descripcion = datos.Lector.GetString(3);
                    aux.Marca = datos.Lector.GetInt32(4);
                    aux.descripcionMarca = datos.Lector.GetString(5);
                    aux.Categoria = datos.Lector.GetInt32(6);
                    aux.descripcionCategoria = datos.Lector.GetString(7);

                    
                    aux.Precio = (float)datos.Lector.GetDecimal(8);

                    if (!datos.Lector.IsDBNull(9)) 
                    {
                        aux.imagen = new Imagen();
                        aux.imagen.url = datos.Lector.GetString(9);
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
        }*/
        public List<Articulo> listar()
        {
            List<Articulo> listaArticulo = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta(@"
            SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, A.IdMarca, M.Descripcion AS MarcaDescripcion, 
                   A.IdCategoria, C.Descripcion AS CategoriaDescripcion, A.Precio 
            FROM ARTICULOS A
            LEFT JOIN MARCAS M ON A.IdMarca = M.Id
            LEFT JOIN CATEGORIAS C ON A.IdCategoria = C.Id");

                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = datos.Lector.GetInt32(0);
                    aux.Codigo = datos.Lector.IsDBNull(1) ? null : datos.Lector.GetString(1);
                    aux.Nombre = datos.Lector.IsDBNull(2) ? null : datos.Lector.GetString(2);
                    aux.Descripcion = datos.Lector.IsDBNull(3) ? null : datos.Lector.GetString(3);
                    aux.IdMarca = datos.Lector.IsDBNull(4) ? 0 : datos.Lector.GetInt32(4);
                    aux.Marca = datos.Lector.IsDBNull(5) ? null : datos.Lector.GetString(5);
                    aux.IdCategoria = datos.Lector.IsDBNull(6) ? 0 : datos.Lector.GetInt32(6);
                    aux.Categoria = datos.Lector.IsDBNull(7) ? null : datos.Lector.GetString(7);
                    aux.Precio = datos.Lector.IsDBNull(8) ? 0 : (float)datos.Lector.GetDecimal(8);

                    ImagenesNegocio negocioImagen = new ImagenesNegocio();
                    aux.Imagen = new List<Imagen>();
                    aux.Imagen = negocioImagen.listarPorIdArticulo(aux.Id);

                    /*
                    Imagen imagen = new Imagen();
                    imagen.Id = datos.Lector.IsDBNull(9) ? 0 : datos.Lector.GetInt32(9);
                    imagen.Articulo = aux.Id;
                    imagen.url = datos.Lector.IsDBNull(10) ? "" : datos.Lector.GetString(10);
                    
                    aux.Imagen = new List<Imagen>();
                    aux.Imagen.Add(imagen);
                    */
                    listaArticulo.Add(aux);
                    
                }

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
                datos.setearParametro("@Codigo", nuevo.Codigo);
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@Descripcion", nuevo.Descripcion);
                datos.setearParametro("@IdCategoria", nuevo.IdCategoria);
                datos.setearParametro("@IdMarca", nuevo.IdMarca);
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
                datos.setearParametro("@Codigo", articulo.Codigo);
                datos.setearParametro("@Nombre", articulo.Nombre);
                datos.setearParametro("@Descripcion", articulo.Descripcion);
                datos.setearParametro("@IdMarca", articulo.IdMarca);
                datos.setearParametro("@IdCategoria", articulo.IdCategoria);
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
   
        public int buscarPorIdPorCodigo(string codigo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select Id from Articulos where Codigo = @CodigoArticulo");
                datos.setearParametro("@CodigoArticulo", codigo);
                datos.ejecutarLectura();
                int Id= 0;

                if (datos.Lector.Read())
                {
                    Id = datos.Lector.GetInt32(0);
                }

                
                    return Id;
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
