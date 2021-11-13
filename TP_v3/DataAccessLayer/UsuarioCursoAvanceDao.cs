using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_v3.Entities;

namespace TP_v3.DataAccessLayer
{
    public class UsuarioCursoAvanceDao
    {
        public IList<UsuariosCurso> ObtenerUsuariosCurso(string user)
        {
            List<UsuariosCurso> listaUsuariosCurso = new List<UsuariosCurso>();
            //var query = string.Concat("SELECT id_usuario, ",
              //                            "   id_curso, ",
              //                            "   puntuacion, ",
              //                            "   observaciones, ",
              //                            "   fecha_inicio, ",
              //                            "   fecha_fin ",
              //                            "FROM UsuariosCursos c ");
              //                            //"WHERE id_usuario = @Search ");
            var parametros = new Dictionary<string, object>();
            parametros.Add("@idCurso", user);
            var resultadoConsulta = DataManager.GetInstance().ConsultaSQL("SP_SEL_UsuariosCurso", parametros);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listaUsuariosCurso.Add(ObjectMapping(row));
            }
            return listaUsuariosCurso;
        }
        private UsuariosCurso ObjectMapping(DataRow row)
        {
            UsuariosCurso oUsuariosCurso = new UsuariosCurso
            {
                IdUsuario = new Usuario
                {
                    idUsuario = Convert.ToInt32(row["id_usuario"].ToString())
                },
                IdCurso = new Curso
                {
                    idCurso = Convert.ToInt32(row["id_curso"].ToString())
                },
                Puntuacion = Convert.ToInt32(row["puntuacion"].ToString()),
                Observacion = (row["observaciones"].ToString()),
                Inicio = Convert.ToDateTime(row["fecha_inicio"]),
                Fin = Convert.ToDateTime(row["Fecha_fin"]),
            };
            return oUsuariosCurso;
        }
        public bool InsertarAvance(UsuariosCursoAvance usuariosCursoAvance, int todos)
        {
            var string_conection = "Data Source=.\\SQLEXPRESS;Initial Catalog=TPPAVI;Integrated Security=True";

            SqlConnection dbConnection = new SqlConnection();
            SqlTransaction dbTransaction = null;

            try
            {
                dbConnection.ConnectionString = string_conection;
                dbConnection.Open();
                    
                dbTransaction = dbConnection.BeginTransaction();

                //INSERT UsuariosCursoAvance
                SqlCommand insertAvance = new SqlCommand();
                insertAvance.Connection = dbConnection;
                insertAvance.CommandType = CommandType.Text;
                //Establece la query
                insertAvance.CommandText = "INSERT INTO UsuariosCursoAvance (id_usuario, id_curso, inicio, fin, porc_avance, fecha_registro )" +
                           "VALUES (@idUsuario, @idCurso, @inicio, @fin, @porcAvance, @fechaReg)";
                insertAvance.Parameters.AddWithValue("idUsuario", usuariosCursoAvance.idUsuario.idUsuario);
                insertAvance.Parameters.AddWithValue("idCurso", usuariosCursoAvance.idCurso.idCurso);
                insertAvance.Parameters.AddWithValue("inicio", usuariosCursoAvance.inicio);
                insertAvance.Parameters.AddWithValue("fin", usuariosCursoAvance.fin);
                insertAvance.Parameters.AddWithValue("porcAvance", usuariosCursoAvance.porcAvance);
                insertAvance.Parameters.AddWithValue("fechaReg", DateTime.Now);

                insertAvance.Transaction = dbTransaction;
                insertAvance.ExecuteNonQuery();

                //UPDATE UsuariosCurso con el avance
                if (todos == 0)
                {
                    SqlCommand updateAvanceCurso = new SqlCommand();
                    updateAvanceCurso.Connection = dbConnection;
                    updateAvanceCurso.CommandType = CommandType.Text;
                    //Establece la query
                    updateAvanceCurso.CommandText = "UPDATE UsuariosCurso SET avance = @avance WHERE id_usuario = @idUsuario AND id_curso = @idCurso";

                    updateAvanceCurso.Parameters.AddWithValue("avance", usuariosCursoAvance.porcAvance);
                    updateAvanceCurso.Parameters.AddWithValue("idUsuario", usuariosCursoAvance.idUsuario.idUsuario);
                    updateAvanceCurso.Parameters.AddWithValue("idCurso", usuariosCursoAvance.idCurso.idCurso);

                    updateAvanceCurso.Transaction = dbTransaction;
                    updateAvanceCurso.ExecuteNonQuery();
                }
                else
                {
                    SqlCommand updateAvanceCurso = new SqlCommand();
                    updateAvanceCurso.Connection = dbConnection;
                    updateAvanceCurso.CommandType = CommandType.Text;
                    //Establece la query
                    updateAvanceCurso.CommandText = "UPDATE UsuariosCurso SET avance = @avance WHERE id_curso = @idCurso";

                    updateAvanceCurso.Parameters.AddWithValue("avance", usuariosCursoAvance.porcAvance);
                    updateAvanceCurso.Parameters.AddWithValue("idCurso", usuariosCursoAvance.idCurso.idCurso);

                    updateAvanceCurso.Transaction = dbTransaction;
                    updateAvanceCurso.ExecuteNonQuery();
                }
                dbTransaction.Commit();
            }
            catch (Exception ex)
            {
                var mensaje = "Error: " + ex.Message;
                if (ex.InnerException != null)
                {
                    mensaje = mensaje + " Inner exception: " + ex.InnerException.Message;
                }
                mensaje = mensaje + " Stack trace: " + ex.StackTrace;
                
                dbTransaction.Rollback();
            }
            return true;
        }
    }
}
