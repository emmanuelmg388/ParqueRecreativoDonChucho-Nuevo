using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace CapaDatos
{
    public class SesionRepositorio
    {
        private readonly string cadena = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
        private string sql = "";

        // Insertar
        public void InsertarSesion(Sesion s)
        {
            using (MySqlConnection con = new MySqlConnection(cadena))
            {
                sql = @"INSERT INTO sesion(CodigoAtraccion, CodigoJuego, NumeroZona, HoraInicio, BoletosVendidos) 
                        VALUES(@CodigoAtraccion, @CodigoJuego, @NumeroZona, @HoraInicio, @BoletosVendidos)";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@CodigoAtraccion", s.CodigoAtraccion);
                cmd.Parameters.AddWithValue("@CodigoJuego", s.CodigoJuego);
                cmd.Parameters.AddWithValue("@NumeroZona", s.NumeroZona);
                cmd.Parameters.AddWithValue("@HoraInicio", s.HoraInicio);
                cmd.Parameters.AddWithValue("@BoletosVendidos", s.BoletosVendidos);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Actualizar
        public void ActualizarSesion(Sesion s)
        {
            using (MySqlConnection con = new MySqlConnection(cadena))
            {
                sql = @"UPDATE sesion 
                        SET CodigoAtraccion=@CodigoAtraccion, CodigoJuego=@CodigoJuego, NumeroZona=@NumeroZona, 
                            HoraInicio=@HoraInicio, BoletosVendidos=@BoletosVendidos
                        WHERE IdSesion=@IdSesion";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@IdSesion", s.IdSesion);
                cmd.Parameters.AddWithValue("@CodigoAtraccion", s.CodigoAtraccion);
                cmd.Parameters.AddWithValue("@CodigoJuego", s.CodigoJuego);
                cmd.Parameters.AddWithValue("@NumeroZona", s.NumeroZona);
                cmd.Parameters.AddWithValue("@HoraInicio", s.HoraInicio);
                cmd.Parameters.AddWithValue("@BoletosVendidos", s.BoletosVendidos);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Eliminar
        public void EliminarSesion(int idSesion)
        {
            using (MySqlConnection con = new MySqlConnection(cadena))
            {
                sql = @"DELETE FROM sesion WHERE IdSesion=@IdSesion";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@IdSesion", idSesion);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Buscar
        public DataTable BuscarSesion(int idSesion)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection con = new MySqlConnection(cadena))
            {
                sql = @"SELECT * FROM sesion WHERE IdSesion=@IdSesion";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@IdSesion", idSesion);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        // Listar
        public DataTable ListarSesiones()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection con = new MySqlConnection(cadena))
            {
                sql = @"SELECT * FROM sesion;";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }
    }
}
