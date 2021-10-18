using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_v3.Entities;

namespace TP_v3.DataAccessLayer
{
    public class ObjetivoDao
    {
        public bool InsertarObjetivo(Objetivo objetivo)
        {
            string query = "INSERT INTO Objetivos (nombre_corto, nombre_largo, borrado )" +
                           "VALUES (@Nombre_corto, @Nombre_largo, 0 )";

            var parametros = new Dictionary<string, object>();
            parametros.Add("nombre_corto", objetivo.nombreCorto);
            parametros.Add("nombre_largo", objetivo.nombreLargo);

            // Si una fila es afectada por la inserción retorna TRUE. Caso contrario FALSE

            return (DataManager.GetInstance().EjecutarSQL(query, parametros) == 1);
        }
        public IList<Objetivo> ObtenerObjetivos(string search = null)
        {
            List<Objetivo> listaObjetivo = new List<Objetivo>();
            String query = string.Concat("SELECT id_objetivo, ",
                                          "nombre_corto ,",
                                          "nombre_largo, ",
                                          "borrado ",
                                          "FROM Objetivos ",
                                          "WHERE borrado = 0 ");

            if (!string.IsNullOrEmpty(search))
            {
                query += "WHERE nombre LIKE @Search OR descripcion LIKE @Search";
                var parametros = new Dictionary<string, object>();
                parametros.Add("@Search", $"%{search}%");
                var resultadoConsulta = DataManager.GetInstance().ConsultaSQL(query, parametros);
                foreach (DataRow row in resultadoConsulta.Rows)
                {
                    listaObjetivo.Add(ObjectMappingUser(row));
                }
                return listaObjetivo;
            }
            else
            {
                var resultadoConsulta = DataManager.GetInstance().ConsultaSQL(query);
                foreach (DataRow row in resultadoConsulta.Rows)
                {
                    listaObjetivo.Add(ObjectMappingUser(row));
                }
                return listaObjetivo;
            }
        }
        public void EliminarObjetivo(int id)
        {
            string query = @"DELETE FROM Objetivos WHERE id_objetivo = @id";

            var parametros = new Dictionary<string, object>();
            parametros.Add("@id", id);

            DataManager.GetInstance().ConsultaSQL(query, parametros);
        }
        public bool ActualizarObjetivo(Objetivo objetivo)
        {
            string query = @"UPDATE Objetivos
                             SET nombre_corto = @Nombre_corto,
                                 nombre_largo = @Nombre_largo,
                                 borrado = @Borrado
                             WHERE id_objetivo = @Id ";

            var parametros = new Dictionary<string, object>();

            parametros.Add("@Id", objetivo.idObjetivo);
            parametros.Add("@Nombre_corto", objetivo.nombreCorto);
            parametros.Add("@Nombre_largo", objetivo.nombreLargo);
            parametros.Add("@Borrado", objetivo.borrado);

            return (DataManager.GetInstance().EjecutarSQL(query, parametros) == 1);
        }
        private Objetivo ObjectMappingUser(DataRow row)
        {
            Objetivo oObjetivo = new Objetivo
            {
                idObjetivo = Convert.ToInt32(row["id_objetivo"].ToString()),
                nombreCorto = row["nombre_corto"].ToString(),
                nombreLargo = row["nombre_largo"].ToString(),
                borrado = Convert.ToBoolean(row["borrado"]),
            };
            return oObjetivo;
        }
    }
}
