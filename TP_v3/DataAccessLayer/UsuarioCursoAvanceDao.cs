using System;
using System.Collections.Generic;
using System.Data;
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
            var query = string.Concat("SELECT id_usuario, ",
                                          "   id_curso, ",
                                          "   puntuacion, ",
                                          "   observaciones, ",
                                          "   fecha_inicio, ",
                                          "   fecha_fin ",
                                          "FROM UsuariosCursos c ");
                                          //"WHERE id_usuario = @Search ");
            var parametros = new Dictionary<string, object>();
            parametros.Add("@Search", user);
            var resultadoConsulta = DataManager.GetInstance().ConsultaSQL(query, parametros);

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
    }
}
