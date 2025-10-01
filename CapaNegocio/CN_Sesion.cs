using System;
using CapaDatos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public struct Sesion
    {
        public readonly string id;
        public readonly string atraccion;
        public readonly string juego;
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
    }
}
