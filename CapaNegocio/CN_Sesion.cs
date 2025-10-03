using System;
using CapaDatos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Deployment.Internal;

namespace CapaNegocio
{
    public struct Sesion
    {
        public string id;
        public string atraccion;
        public string juego;
        public string area;
        public DateTime inicio;
        public int boletos;
    }
    public class CN_Sesion
    {
        private readonly SesionRepositorio objCD = new SesionRepositorio();

        public void Crear(Sesion obj)
        {
            objCD.InsertarSesion(new CapaDatos.Sesion()
            {
                IdSesion = int.Parse(obj.id),
                CodigoAtraccion = obj.atraccion,
                CodigoJuego = obj.juego,
                NumeroZona = int.Parse(obj.area),
                HoraInicio = obj.inicio,
                BoletosVendidos = obj.boletos
            });
        }

        public DataTable Buscar(string id)
        {
            return objCD.BuscarSesion(int.Parse(id));
        }

        public DataTable Listar()
        {
            return objCD.ListarSesiones();
        }
    }
}
