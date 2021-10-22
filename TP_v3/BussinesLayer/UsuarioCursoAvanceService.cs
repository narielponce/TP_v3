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
        public UsuarioCursoAvanceService()
        {
            _usuarioCursoAvanceDao = new UsuarioCursoAvanceDao();
        }
        //public List<UsuariosCurso> ObtenerUsuariosCursos()
        //{
        //    return (List<UsuariosCurso>)_cursoDao.ObtenerCursos();
        //}

    }
}
