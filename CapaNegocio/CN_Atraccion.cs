using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public struct Atraccion
    {
        public readonly string id;
        public string nombre;
        public decimal precio;
        public int capacidad;

    }

    public class CN_Atraccion
    {
        public void Crear(Atraccion obj)
        {

        }

        public void Actualizar(Atraccion obj)
        {

        }

        public Atraccion Buscar(string id)
        {
            Atraccion result = new Atraccion();
            return result;
        }

        public List<Atraccion> Listar()
        {
            return null;
        }
    }
}
