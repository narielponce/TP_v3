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
    public class UsuarioCursoDao
    {
        public bool InsertarUsuarioCurso(UsuariosCurso usuariosCurso)
        {
            string query = "INSERT INTO UsuariosCurso (id_usuario, id_curso, puntuacion, observaciones, fecha_inicio, fecha_fin, avance )" +
                           "VALUES (@IdUsuario, @IdCurso, @Puntuacion, @Observaciones, @FechaInicio, @FechaFin, 0 )";

            var parametros = new Dictionary<string, object>();
            parametros.Add("IdUsuario", usuariosCurso.IdUsuario.idUsuario);
            parametros.Add("IdCurso", usuariosCurso.IdCurso.idCurso);
            parametros.Add("Puntuacion", usuariosCurso.Puntuacion);
            parametros.Add("Observaciones", usuariosCurso.Observacion);
            parametros.Add("FechaInicio", usuariosCurso.Inicio);
            parametros.Add("FechaFin", usuariosCurso.Fin);

            // Si una fila es afectada por la inserción retorna TRUE. Caso contrario FALSE

            return (DataManager.GetInstance().EjecutarSQL(query, parametros) == 1);
        }
        public IList<UsuariosCurso> ObtenerUsuarioCurso(Dictionary<string, object> parametros)
        {
            List<UsuariosCurso> listaUsuariosCurso = new List<UsuariosCurso>();
            var query = string.Concat("SELECT id_usuario, ",
                                          "   id_curso, ",
                                          "   puntuacion, ",
                                          "   observaciones, ",
                                          "   fecha_inicio, ",
                                          "   fecha_fin ",
                                          "FROM UsuariosCursos ");
                                          //"INNER JOIN Cursos c ON u.id_usuario= c.id_usuario ");
            if (parametros.ContainsKey("idUsuario"))
                query += " AND (u.id_usuario=idUsuario) ";

            var resultadoConsulta = DataManager.GetInstance().ConsultaSQL(query, parametros).Rows;

            foreach (DataRow row in resultadoConsulta)
            {
                listaUsuariosCurso.Add(ObjectMapping(row));
            }
            return listaUsuariosCurso;
        }
        public IList<UsuariosCurso> GetUsuarioCursoById(int idUsuario)
        {
            List<UsuariosCurso> listadoUsuariosCurso = new List<UsuariosCurso>();
            //var query = string.Concat("SELECT id_usuario, ",
            //                              "   id_curso, ",
            //                              "   puntuacion, ",
            //                              "   observaciones, ",
            //                              "   fecha_inicio, ",
            //                             "   fecha_fin ",
            //                              "FROM UsuariosCurso ",
            //                              "WHERE id_usuario = @IdUser ");

            var parametros = new Dictionary<string, object>();
            //parametros.Add("@IdUser", idUsuario);
            parametros.Add("@IdUsuario", idUsuario);

            //var resultadoConsulta = DataManager.GetInstance().ConsultaSQL(query, parametros);
            var resultadoConsulta =  DataMngrSp.DataMngrSP.GetInstance().ConsultaSQL("SP_SEL_UsuariosCurso", parametros);
            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoUsuariosCurso.Add(ObjectMapping(row));
            }
            return listadoUsuariosCurso;
        }
        private UsuariosCurso ObjectMapping(DataRow row)
        {
            UsuariosCurso oUsuariosCurso = new UsuariosCurso();

            oUsuariosCurso.IdUsuario = new Usuario();
            //oUsuariosCurso.IdUsuario.idUsuario = Convert.ToInt32(row["id_usuario"].ToString());
            //oUsuariosCurso.IdUsuario.idUsuario = Convert.ToInt32(row["usuario"].ToString());
            oUsuariosCurso.IdUsuario.nombreUsuario = row["usuario"].ToString();

            oUsuariosCurso.IdCurso = new Curso();
            //oUsuariosCurso.IdCurso.idCurso = Convert.ToInt32(row["id_curso"].ToString());
            oUsuariosCurso.IdCurso.nombre = row["curso"].ToString();

            oUsuariosCurso.Puntuacion = Convert.ToInt32(row["puntuacion"].ToString());
            oUsuariosCurso.Observacion = row["observaciones"].ToString();
            oUsuariosCurso.Inicio = Convert.ToDateTime(row["fecha_inicio"]);
            oUsuariosCurso.Fin = Convert.ToDateTime(row["fecha_fin"]);
            
            return oUsuariosCurso;
        }
    }
}
