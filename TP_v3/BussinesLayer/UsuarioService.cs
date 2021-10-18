using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_v3.DataAccessLayer;
using TP_v3.Entities;

namespace TP_v3.BussinesLayer
{
    
    public class UsuarioService
    {
        private readonly UsuarioDao _usuarioDao;
        public UsuarioService()
        {
            _usuarioDao = new UsuarioDao();
        }
        public List<Usuario> ObtenerUsuarios()
        {
            return (List<Usuario>)_usuarioDao.ObtenerUsuarios();
        }
    }
}
