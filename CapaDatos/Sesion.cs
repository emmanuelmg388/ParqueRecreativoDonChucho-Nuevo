using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Sesion
    {
        public int IdSesion { get; set; }             
        public string CodigoAtraccion { get; set; }    
        public string CodigoJuego { get; set; }        
        public int NumeroZona { get; set; }
        public DateTime HoraInicio { get; set; }
        public int BoletosVendidos { get; set; }
    }
}
