using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_v3.Entities;

namespace TP_v3.DataAccessLayer
{
    public class CategoriaDao
    {
        public bool ActualizarCategoria(Categoria categoria)
        {
            string query = @"UPDATE Categorias
                             SET nombre = @Nombre,
                                 descripcion = @Descripcion,
                                 borrado = @Borrado
                             WHERE id_categoria = @Id ";

            var parametros = new Dictionary<string, object>();

            parametros.Add("@Id", categoria.idCategoria);
            parametros.Add("@Nombre", categoria.nombreCateg);
            parametros.Add("@Descripcion", categoria.descripcion);
            parametros.Add("@Borrado", categoria.borrado);

            return (DataManager.GetInstance().EjecutarSQL(query, parametros) == 1);
        }
        public bool InsertarCategoria(Categoria categoria)
        {
            string query = "INSERT INTO Categorias (nombre, descripcion, borrado )" +
                           "VALUES (@Nombre, @Descripcion, 0 )";

            var parametros = new Dictionary<string, object>();
            parametros.Add("nombre", categoria.nombreCateg);
            parametros.Add("descripcion", categoria.descripcion);

            // Si una fila es afectada por la inserción retorna TRUE. Caso contrario FALSE

            return (DataManager.GetInstance().EjecutarSQL(query, parametros) == 1);
        }
        public void EliminarCategoria(int id)
        {
            string query = @"DELETE FROM Categorias WHERE id_categoria = @id";

            var parametros = new Dictionary<string, object>();
            parametros.Add("@id", id);

            DataManager.GetInstance().ConsultaSQL(query, parametros);
        }
        
        public IList<Categoria> ObtenerCategorias(string search = null)
        {
            List<Categoria> listaCategoria = new List<Categoria>();
            String query = string.Concat("SELECT id_categoria, ",
                                          "nombre, ",
                                          "descripcion, ",
                                          "borrado ",
                                          "FROM Categorias ");
                                          //"WHERE borrado = 0 ");
            
            if (!string.IsNullOrEmpty(search))
            {
                query += "WHERE nombre LIKE @Search OR descripcion LIKE @Search";
                var parametros = new Dictionary<string, object>();
                parametros.Add("@Search", $"%{search}%");
                var resultadoConsulta = DataManager.GetInstance().ConsultaSQL(query, parametros);
                foreach (DataRow row in resultadoConsulta.Rows)
                {
                    listaCategoria.Add(ObjectMappingUser(row));
                }
                return listaCategoria;
            }
            else
            {
                var resultadoConsulta = DataManager.GetInstance().ConsultaSQL(query);
                foreach (DataRow row in resultadoConsulta.Rows)
                {
                    listaCategoria.Add(ObjectMappingUser(row));
                }
                return listaCategoria;
            }
        }
        private Categoria ObjectMappingUser(DataRow row)
        {
            Categoria oCategoria = new Categoria
            {
                idCategoria = Convert.ToInt32(row["id_categoria"].ToString()),
                nombreCateg = row["nombre"].ToString(),
                descripcion = row["descripcion"].ToString(),
                borrado = Convert.ToBoolean(row["borrado"]),
            };
            return oCategoria;
        }
    }
}
