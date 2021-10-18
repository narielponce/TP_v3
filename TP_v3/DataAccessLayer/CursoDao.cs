using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_v3.Entities;

namespace TP_v3.DataAccessLayer
{
    public class CursoDao
    {
        public bool ActualizarCurso(Curso curso)
        {
            string query = @"UPDATE Cursos
                             SET nombre = @Nombre,
                                 descripcion = @Descripcion,
                                 fecha_vigencia = @Fecha_vigencia,
                                 id_categoria = @Id_categoria,
                                 borrado = @Borrado
                             WHERE id_curso = @Id ";

            var parametros = new Dictionary<string, object>();

            parametros.Add("@Id", curso.idCurso);
            parametros.Add("@Nombre", curso.nombre);
            parametros.Add("@Descripcion", curso.descripcion);
            parametros.Add("@Fecha_vigencia", curso.fechaVigencia);
            parametros.Add("@Id_categoria", curso.idCategoria);
            parametros.Add("@Borrado", curso.borrado);

            return (DataManager.GetInstance().EjecutarSQL(query, parametros) == 1);
        }
            
        public bool InsertarCurso(Curso curso)
        {
            string query = "INSERT INTO Cursos (nombre, descripcion, fecha_vigencia, id_categoria, borrado )" + 
                           "VALUES (@Nombre, @Descripcion, @Fecha_vigencia, @Id_categoria, 0)";

            var parametros = new Dictionary<string, object>();
            parametros.Add("nombre", curso.nombre);
            parametros.Add("descripcion", curso.descripcion);
            parametros.Add("fecha_vigencia", curso.fechaVigencia);
            parametros.Add("id_categoria", curso.idCategoria.idCategoria);

            // Si una fila es afectada por la inserción retorna TRUE. Caso contrario FALSE

            return (DataManager.GetInstance().EjecutarSQL(query, parametros) == 1);
        }

        public void EliminarCurso(int id)
        {
            //conn.Open();
            string query = @"DELETE FROM Cursos WHERE id_curso = @id";

            var parametros = new Dictionary<string, object>();
            parametros.Add("@id", id);

            DataManager.GetInstance().ConsultaSQL(query, parametros);
        }
        public bool BajaLogicaCurso(int id)
        {
            string query = @"UPDATE Cursos
                             SET borrado = @Borrado
                             WHERE id_curso = @Id ";

            var parametros = new Dictionary<string, object>();

            parametros.Add("@Id", id);
            parametros.Add("@Borrado", 1);

            return (DataManager.GetInstance().EjecutarSQL(query, parametros) == 1);
        }

        public IList<Curso> ObtenerCursos(string search = null)
        {
            List<Curso> listaCurso = new List<Curso>();
            String query = string.Concat("SELECT c.id_curso, ",
                                          "      c.nombre, ",
                                          "      c.descripcion, ",
                                          "      c.fecha_vigencia, ",
                                          "      t.id_categoria, ",
                                          "      t.nombre categoria, ",
                                          "      c.borrado ",    
                                          "FROM Cursos c ",
                                          "INNER JOIN Categorias t ON c.id_categoria= t.id_categoria ",
                                          "WHERE c.borrado = 0 ");
            var resultadoConsulta = DataManager.GetInstance().ConsultaSQL(query);
            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listaCurso.Add(ObjectMapping(row));
            }
            return listaCurso;

            
        }
        public IList<Curso> ObtenerCursosSearch(string search)
        {
            List<Curso> listaCurso = new List<Curso>();
            String query = string.Concat("SELECT c.id_curso, ",
                                          "      c.nombre, ",
                                          "      c.descripcion, ",
                                          "      c.fecha_vigencia, ",
                                          "      t.id_categoria, ",
                                          "      t.nombre categoria, ",
                                          "      c.borrado ",
                                          "FROM Cursos c ",
                                          "INNER JOIN Categorias t ON c.id_categoria= t.id_categoria ",
                                          "WHERE c.borrado = 0 ");
            query += " OR c.nombre LIKE @Search OR c.descripcion LIKE @Search ";
            var parametros = new Dictionary<string, object>();
            parametros.Add("@Search", $"%{search}%");
            var resultadoConsulta = DataManager.GetInstance().ConsultaSQL(query, parametros);
            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listaCurso.Add(ObjectMapping(row));
            }
            return listaCurso;
        }
        public IList<Curso> GetByFilters(Dictionary<string, object> parametros)
        {
            List<Curso> listadoCursos = new List<Curso>();

            var strSql = String.Concat("SELECT c.id_curso, ",
                                          "      c.nombre, ",
                                          "      c.descripcion, ",
                                          "      c.fecha_vigencia, ",
                                          "      t.id_categoria, ",
                                          "      t.nombre categoria, ",
                                          "      c.borrado ",
                                          "FROM Cursos c ",
                                          "INNER JOIN Categorias t ON c.id_categoria= t.id_categoria ");

            if (parametros.ContainsKey("idCategoria"))
                strSql += " AND (t.id_categoria=@idCategoria) ";

            var resultadoConsulta = (DataRowCollection)DataManager.GetInstance().ConsultaSQL(strSql, parametros).Rows;

            foreach (DataRow row in resultadoConsulta)
            {
                listadoCursos.Add(ObjectMapping(row));
            }

            return listadoCursos;
        }
        private Curso ObjectMapping(DataRow row)
        {
            Curso oCurso = new Curso
            {
                idCurso = Convert.ToInt32(row["id_curso"].ToString()),
                nombre = row["nombre"].ToString(),
                descripcion = row["descripcion"].ToString(),
                fechaVigencia = Convert.ToDateTime(row["fecha_vigencia"]),
                borrado = Convert.ToBoolean(row["borrado"]),
                idCategoria = new Categoria()
                {
                    idCategoria = Convert.ToInt32(row["id_categoria"].ToString()),
                    nombreCateg = row["categoria"].ToString(),
                }
            };
            return oCurso;
        }
    }
}
