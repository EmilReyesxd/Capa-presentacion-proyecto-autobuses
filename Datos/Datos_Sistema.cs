using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;
using System.Data;
using System.Configuration;

namespace Datos
{
    public class Datos_Sistema
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["StrCon"].ConnectionString);
        public List<Entidad_Sistema> ListarSistema(string buscar)
        {
            SqlDataReader leerfilas;
            SqlCommand cmd = new SqlCommand("SP_BUSCARSISTEMA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", buscar);
            leerfilas = cmd.ExecuteReader();

            List<Entidad_Sistema> listar = new List<Entidad_Sistema>();
            while (leerfilas.Read())
            {
                listar.Add(new Entidad_Sistema
                {
                    IdSistema = leerfilas.GetInt32(0),
                    CodigoSistema = leerfilas.GetString(1),
                    Autobuses = leerfilas.GetString(2),
                    Choferes = leerfilas.GetString(3),
                    Rutas = leerfilas.GetString(4)
                });
            }
            conexion.Close();
            leerfilas.Close();
            return listar;
        }
        public void InsertarSistema(Entidad_Sistema sistema)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTARSISTEMA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@AUTOBUSES", sistema.Autobuses);
            cmd.Parameters.AddWithValue("@CHOFERES", sistema.Choferes);
            cmd.Parameters.AddWithValue("@RUTAS", sistema.Rutas);

            cmd.ExecuteNonQuery();

            conexion.Close();


        }
        public void EditarSistema(Entidad_Sistema sistema)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITARSISTEMA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDSISTEMA", sistema.IdSistema);
            cmd.Parameters.AddWithValue("@AUTOBUSES", sistema.IdSistema);
            cmd.Parameters.AddWithValue("@CHOFERES", sistema.IdSistema);
            cmd.Parameters.AddWithValue("@RUTAS", sistema.IdSistema);

        }
        public void EliminarSistema(Entidad_Sistema sistema)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINARSISTEMA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDSISTEMA", sistema.IdSistema);
            cmd.ExecuteNonQuery();
            conexion.Close();

        }
    }
}
