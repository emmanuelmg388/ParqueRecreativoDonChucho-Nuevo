using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public struct Juego
    {
        public readonly string id;
        public string nombre;
        public int duracion;
        public string categoria;
    }
    public class CN_Juego
    {
        public void Crear(Juego obj)
        {

        }

        public Juego Buscar(string id)
        {
            Juego result = new Juego();
            return result;
        }

        public List<Juego> Listar()
        {
            return null;
        }
    }
}
