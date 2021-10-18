using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_v3.DataAccessLayer
{
    public class DataManager
    {
        private string cadena_de_conexion;
        private static DataManager instance;
        public DataManager()
        {
            this.cadena_de_conexion = "Data Source=.\\SQLEXPRESS;Initial Catalog=TPPAVI;Integrated Security=True;";
        }
        // en este método aplicamos el patrón singleton.
        // si ya existe una instancia DataManager no hacemos nada, caso contrario la creamos.
        public static DataManager GetInstance()
        {
            if (instance is null)
            {
                instance = new DataManager();
            }
            return instance;
        }
        
        // Consulta SQL
        public DataTable ConsultaSQL(string consulta, Dictionary<string, object> parametros = null)
        {
            SqlConnection dbConnection = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();

            try
            {
                dbConnection.ConnectionString = cadena_de_conexion; // cadena de conexion
                dbConnection.Open(); // nos conectamos
                cmd.Connection = dbConnection; // asignamos la conexion a nuestro cmd
                cmd.CommandType = CommandType.Text; // le decimos que va ser un comando tipo texto
                cmd.CommandText = consulta; // asignamos al comando la consulta recibida por parámetro

                // en caso de tener parámetros, los agregamos a la consulta
                if (parametros != null)
                {

                    foreach (var un_parametro in parametros)
                    {
                        cmd.Parameters.AddWithValue(un_parametro.Key, un_parametro.Value);
                    }

                }

                tabla.Load(cmd.ExecuteReader()); // ejecutamos la consulta y llenamos la tabla

                return tabla;
            }
            catch (Exception e)
            {
                throw (e);
            }
            finally
            {
                if (dbConnection.State != ConnectionState.Closed)
                    dbConnection.Close();
            }
        }

        // Ejecutar SQL
        public int EjecutarSQL(string consulta, Dictionary<string, object> parametros = null)
        {
            SqlConnection dbConnection = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            int resultado;

            try
            {
                dbConnection.ConnectionString = cadena_de_conexion; // cadena de conexion
                dbConnection.Open(); // nos conectamos
                cmd.Connection = dbConnection; // asignamos la conexion a nuestro cmd
                cmd.CommandType = CommandType.Text; // le decimos que va ser un comando tipo texto
                cmd.CommandText = consulta; // asignamos al comando la consulta recibida por parámetro

                // en caso de tener parámetros, los agregamos a la consulta
                if (parametros != null)
                {

                    foreach (var un_parametro in parametros)
                    {
                        cmd.Parameters.AddWithValue(un_parametro.Key, un_parametro.Value);
                    }

                }

                resultado = cmd.ExecuteNonQuery(); // ejecutamos la consulta y obtenemos filas afectadas
            }
            catch (Exception e)
            {
                throw (e);
            }
            finally
            {
                if (dbConnection.State != ConnectionState.Closed)
                    dbConnection.Close();
            }

            return resultado;
        }
    }
}
