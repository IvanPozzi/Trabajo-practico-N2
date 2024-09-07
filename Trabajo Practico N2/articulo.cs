using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Trabajo_Practico_N2
{

    public class Articulo
    {
        public int Id { get; set; }
        public string codigo_de_articulo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Marca { get; set; }
        public int Categoria { get; set; }
        public float Precio { get; set; }
        public Imagen imagen { get; set; }
    }
}
