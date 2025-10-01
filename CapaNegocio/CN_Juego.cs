using System;
using System.Collections.Generic;
using CapaDatos;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Data;

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

        public Juego Buscar(string id)
        {
            Juego result = new Juego();
            return result;
        }

        public DataTable Listar()
        {
            return objCD.ListarJuegos();
        }
    }
}
