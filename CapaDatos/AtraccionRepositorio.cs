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
    public class AtraccionRepositorio
    {
        private readonly string cadena = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
        private string sql = "";

        // Insertar
        public void InsertarAtraccion(Atraccion a)
        {
            using (MySqlConnection con = new MySqlConnection(cadena))
            {
                sql = @"INSERT INTO atraccion(CodigoAtraccion, Nombre, PrecioEntrada, CapacidadMaxima) 
                        VALUES(@CodigoAtraccion, @Nombre, @PrecioEntrada, @CapacidadMaxima)";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@CodigoAtraccion", a.CodigoAtraccion);
                cmd.Parameters.AddWithValue("@Nombre", a.Nombre);
                cmd.Parameters.AddWithValue("@PrecioEntrada", a.PrecioEntrada);
                cmd.Parameters.AddWithValue("@CapacidadMaxima", a.CapacidadMaxima);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Actualizar
        public void ActualizarAtraccion(Atraccion a)
        {
            using (MySqlConnection con = new MySqlConnection(cadena))
            {
                sql = @"UPDATE atraccion 
                        SET Nombre=@Nombre, PrecioEntrada=@PrecioEntrada, CapacidadMaxima=@CapacidadMaxima
                        WHERE CodigoAtraccion=@CodigoAtraccion";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@CodigoAtraccion", a.CodigoAtraccion);
                cmd.Parameters.AddWithValue("@Nombre", a.Nombre);
                cmd.Parameters.AddWithValue("@PrecioEntrada", a.PrecioEntrada);
                cmd.Parameters.AddWithValue("@CapacidadMaxima", a.CapacidadMaxima);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Eliminar
        public void EliminarAtraccion(string codigoAtraccion)
        {
            using (MySqlConnection con = new MySqlConnection(cadena))
            {
                sql = @"DELETE FROM atraccion WHERE CodigoAtraccion=@CodigoAtraccion";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@CodigoAtraccion", codigoAtraccion);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Buscar
        public DataRow BuscarAtraccion(string codigoAtraccion)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection con = new MySqlConnection(cadena))
            {
                sql = @"SELECT * FROM atraccion WHERE CodigoAtraccion=@CodigoAtraccion";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@CodigoAtraccion", codigoAtraccion);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            }
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0];
            }
            else
            {
                return null;
            }
        }

        // Listar
        public DataTable ListarAtracciones()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection con = new MySqlConnection(cadena))
            {
                sql = @"SELECT * FROM atraccion;";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

    }
}
