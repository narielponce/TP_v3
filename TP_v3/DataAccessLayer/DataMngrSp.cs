using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_v3.DataAccessLayer
{
    public class DataMngrSp
    {
        public class DataMngrSP
        {
            private SqlConnection dbConnection;


            private static DataMngrSP instance;
            public DataMngrSP()
            {
                dbConnection = new SqlConnection();
                var string_conexion = "Data Source=.\\SQLEXPRESS;Initial Catalog=TPPAVI;Integrated Security=true;";
                dbConnection.ConnectionString = string_conexion;
            }

            public static DataMngrSP GetInstance()
            {
                if (instance == null)
                    instance = new DataMngrSP();

                instance.Open();

                return instance;
            }

            public void Open()
            {
                if (dbConnection.State != ConnectionState.Open)
                    dbConnection.Open();
            }

            public void Close()
            {
                if (dbConnection.State != ConnectionState.Closed)
                    dbConnection.Close();
            }

            ///      SQL SELECT (Recibe parámetros desde la interfaz)
            ///      Los parámetros son: Una sentencia sql como string, y un diccionario de objetos)
            ///      Devuelve: Un objeto de tipo DataTable con el resultado de la consulta
            ///      
            ///      Excepciones:
            ///      System.Data.SqlClient.SqlException:
            ///      El error de conexión se produce:
            ///      a) durante la apertura de la conexión
            ///      b) durante la ejecución del comando.
            public DataTable ConsultaSQL(string strSql, Dictionary<string, object> prs = null)
            {
                SqlCommand cmd = new SqlCommand();
                DataTable tabla = new DataTable();
                try
                {
                    cmd.Connection = dbConnection;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = strSql;

                    //Agregamos a la colección de parámetros del comando los filtros recibidos
                    if (prs != null)
                    {
                        foreach (var item in prs)
                        {
                            cmd.Parameters.AddWithValue(item.Key, item.Value);
                        }
                    }

                    tabla.Load(cmd.ExecuteReader());
                    return tabla;
                }
                catch (Exception ex)
                {
                    throw (ex);
                }
            }

            /// Resumen:
            ///     Se utiliza para sentencias SQL del tipo “Insert/Update/Delete”. Recibe por valor una sentencia sql como string
            /// Devuelve:
            ///      un valor entero con el número de filas afectadas por la sentencia ejecutada
            /// Excepciones:
            ///      System.Data.SqlClient.SqlException:
            ///          El error de conexión se produce:
            ///              a) durante la apertura de la conexión
            ///              b) durante la ejecución del comando.
            public int EjecutarSQL(string strSql, Dictionary<string, object> prs = null)
            {
                // Se utiliza para sentencias SQL del tipo “Insert/Update/Delete”

                SqlCommand cmd = new SqlCommand();

                int rtdo = 0;

                // Try Catch Finally
                // Trata de ejecutar el código contenido dentro del bloque Try - Catch
                // Si hay error lo capta a través de una excepción
                // Si no hubo error
                try
                {
                    cmd.Connection = dbConnection;
                    cmd.CommandType = CommandType.Text;
                    // Establece la instrucción a ejecutar
                    cmd.CommandText = strSql;

                    //Agregamos a la colección de parámetros del comando los filtros recibidos
                    if (prs != null)
                    {
                        foreach (var item in prs)
                        {
                            cmd.Parameters.AddWithValue(item.Key, item.Value);
                        }
                    }

                    // Retorna el resultado de ejecutar el comando
                    rtdo = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return rtdo;
            }


            /// Resumen:
            ///     Se utiliza para sentencias SQL del tipo “Select”. Recibe por valor una sentencia sql como string
            /// Devuelve:
            ///      un valor entero
            /// Excepciones:
            ///      System.Data.SqlClient.SqlException:
            ///          El error de conexión se produce:
            ///              a) durante la apertura de la conexión
            ///              b) durante la ejecución del comando.
            public object ConsultaSQLScalar(string strSql)
            {
                SqlCommand cmd = new SqlCommand();
                try
                {
                    cmd.Connection = dbConnection;
                    cmd.CommandType = CommandType.Text;
                    // Establece la instrucción a ejecutar
                    cmd.CommandText = strSql;
                    return cmd.ExecuteScalar();
                }
                catch (SqlException ex)
                {
                    throw (ex);
                }
            }
        }
    }
}
