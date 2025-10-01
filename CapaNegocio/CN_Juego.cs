
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public struct Juego
    {
        public string id;
        public string nombre;
        public int duracion;
        public string categoria;
    }
    public class CN_Juego
    {
        private readonly JuegoRepositorio objCD = new JuegoRepositorio();

        public void Crear(Juego obj)
        {
            objCD.InsertarJuego(new CapaDatos.Juego()
            {
                CodigoJuego = obj.id,
                Nombre = obj.nombre,
                Duracion = obj.duracion,
                Categoria = obj.categoria,
            });

        }

        public DataRow Buscar(string id)
        {
            return objCD.BuscarJuego(id);
        }

        public DataTable Listar()
        {
            return objCD.ListarJuegos();
        }
    }
}
