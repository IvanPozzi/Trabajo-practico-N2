using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Policy;

namespace Trabajo_Practico_N2
{

    public class Imagen
    {
        public int Id { get; set; }
        public int Articulo { get; set; }
        public string url { get; set; }

        public override string ToString()
        {
            return url;
        }

        public string imgNoEncontrada()
        {
            return "https://www.foton.ro/client/img/image-not-found.png";
        }
    }
}
