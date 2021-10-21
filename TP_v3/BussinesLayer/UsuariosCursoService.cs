using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_v3.DataAccessLayer;
using TP_v3.Entities;

namespace TP_v3.BussinesLayer
{
    public class UsuariosCursoService
    {
        private UsuarioCursoDao _usuarioCursoDao;
        public UsuariosCursoService()
        {
            _usuarioCursoDao = new UsuarioCursoDao();
        }
        public UsuariosCurso InsertarUsuarioCurso(UsuariosCurso usuariosCurso)
        {
            _usuarioCursoDao.InsertarUsuarioCurso(usuariosCurso);
            return usuariosCurso;
        }
    }
    
}
