using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public struct Sesion
    {
        public readonly Atraccion atraccion;
        public readonly Juego juego;
        public string area;
        public DateTime inicio;
        public int boletos;
    }
    public class CN_Sesion
    {
        public void Crear(Sesion obj)
        {

        }
    }
}
