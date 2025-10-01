using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Juego
    {
        public string CodigoJuego { get; set; }   // PK
        public string Nombre { get; set; }
        public int Duracion { get; set; }
        public string Categoria { get; set; }
    }//clase
}
