using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_v3.DataAccessLayer;
using TP_v3.Entities;

namespace TP_v3.BussinesLayer
{
    public class UsuarioCursoAvanceService
    {
        UsuarioCursoAvanceDao _usuarioCursoAvanceDao;
        UsuariosCursoAvance _usuariosCursoAvance;
        public UsuarioCursoAvanceService()
        {
            _usuarioCursoAvanceDao = new UsuarioCursoAvanceDao();
            _usuariosCursoAvance = new UsuariosCursoAvance();
        }
        public UsuariosCursoAvance GrabarAvance(UsuariosCursoAvance usuariosCursoAvance, int todos)
        {
            _usuarioCursoAvanceDao.InsertarAvance(usuariosCursoAvance, todos);
            return usuariosCursoAvance;
        }

    }
}
