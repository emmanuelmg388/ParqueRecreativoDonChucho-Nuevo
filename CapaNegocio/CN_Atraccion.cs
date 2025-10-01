using System.Data;
using CapaDatos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public struct Atraccion
    {
        public string id;
        public string nombre;
        public decimal precio;
        public int capacidad;

    }

    public class CN_Atraccion
    {
        private readonly AtraccionRepositorio objCD = new AtraccionRepositorio();

        public void Crear(Atraccion obj)
        {
            objCD.InsertarAtraccion(new CapaDatos.Atraccion()
            {
                CodigoAtraccion = obj.id,
                Nombre = obj.nombre,
                Precio = obj.precio,
                Capacidad = obj.capacidad,
            });
        }

        public void Actualizar(Atraccion obj)
        {
            objCD.ActualizarAtraccion(new CapaDatos.Atraccion()
            {
                CodigoAtraccion = obj.id,
                Nombre = obj.nombre,
                Precio = obj.precio,
                Capacidad = obj.capacidad,
            });
        }

        public Atraccion Buscar(string id)
        {
            DataRow result = objCD.BuscarAtraccion(id);
            return new Atraccion() 
            {
                id = result["CodigoAtraccion"].ToString(),
                nombre = result["Nombre"].ToString(),
                precio = decimal.Parse(result["Precio"].ToString()),
                capacidad = int.Parse(result["Capacidad"].ToString())
            };
        }

        public DataTable Listar()
        {
            return objCD.ListarAtracciones();
        }
    }
}
