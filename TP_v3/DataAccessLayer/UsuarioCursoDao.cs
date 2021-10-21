using System;
using System.Collections.Generic;
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
            string query = "INSERT INTO UsuariosCurso (id_usuario, id_curso, puntuacion, observaciones, fecha_inicio, fecha_fin )" +
                           "VALUES (@IdUsuario, @IdCurso, @Puntuacion, @Observaciones, @FechaInicio, @FechaFin )";

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
    }
}
