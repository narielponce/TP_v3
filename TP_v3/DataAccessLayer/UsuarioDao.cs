using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_v3.Entities;

namespace TP_v3.DataAccessLayer
{
    public class UsuarioDao
    {
        public IList<Usuario> ObtenerUsuarios()
        {
            List<Usuario> listaUsuario = new List<Usuario>();
            String query = string.Concat("SELECT id_usuario, ",
                                         "      usuario, ",
                                         "      email, ",
                                         "      password, ",
                                         "      p.id_perfil, ",
                                         "      p.nombre perfil ",
                                         "      FROM Usuarios u ",
                                         "      INNER JOIN Perfiles p ON u.id_perfil= p.id_perfil " +
                                         "      WHERE u.borrado = 0 ");
            var resultadoConsulta = DataManager.GetInstance().ConsultaSQL(query);
            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listaUsuario.Add(ObjectMapping(row));
            }
            return listaUsuario;
        }
        private Usuario ObjectMapping(DataRow row)
        {
            Usuario oUsuario = new Usuario
            {
                idUsuario = Convert.ToInt32(row["id_usuario"].ToString()),
                perfil = new Perfil()
                {
                    idPerfil = Convert.ToInt32(row["id_perfil"].ToString()),
                    nombrePerfil = row["perfil"].ToString()
                },
                nombreUsuario = row["usuario"].ToString(),
                password = row["password"].ToString(),
                email = row["email"].ToString(),
            };
            return oUsuario;
        }
    }
}
