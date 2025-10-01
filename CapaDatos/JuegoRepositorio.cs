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
    public class JuegoRepositorio
    {
        private readonly string cadena = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
        private string sql = "";

        // Insertar
        public void InsertarJuego(Juego j)
        {
            using (MySqlConnection con = new MySqlConnection(cadena))
            {
                sql = @"INSERT INTO juego(CodigoJuego, Nombre, Duracion, Categoria) 
                        VALUES(@CodigoJuego, @Nombre, @Duracion, @Categoria)";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@CodigoJuego", j.CodigoJuego);
                cmd.Parameters.AddWithValue("@Nombre", j.Nombre);
                cmd.Parameters.AddWithValue("@Duracion", j.Duracion);
                cmd.Parameters.AddWithValue("@Categoria", j.Categoria);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Actualizar
        public void ActualizarJuego(Juego j)
        {
            using (MySqlConnection con = new MySqlConnection(cadena))
            {
                sql = @"UPDATE juego 
                        SET Nombre=@Nombre, Duracion=@Duracion, Categoria=@Categoria
                        WHERE CodigoJuego=@CodigoJuego";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@CodigoJuego", j.CodigoJuego);
                cmd.Parameters.AddWithValue("@Nombre", j.Nombre);
                cmd.Parameters.AddWithValue("@Duracion", j.Duracion);
                cmd.Parameters.AddWithValue("@Categoria", j.Categoria);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Eliminar
        public void EliminarJuego(string codigoJuego)
        {
            using (MySqlConnection con = new MySqlConnection(cadena))
            {
                sql = @"DELETE FROM juego WHERE CodigoJuego=@CodigoJuego";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@CodigoJuego", codigoJuego);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Buscar
        public DataTable BuscarJuego(string codigoJuego)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection con = new MySqlConnection(cadena))
            {
                sql = @"SELECT * FROM juego WHERE CodigoJuego=@CodigoJuego";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@CodigoJuego", codigoJuego);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        // Listar
        public DataTable ListarJuegos()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection con = new MySqlConnection(cadena))
            {
                sql = @"SELECT * FROM juego;";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }
    }
}
