using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_v3.DataAccessLayer;
using TP_v3.Entities;

namespace TP_v3.BussinesLayer
{
    public class CursoService
    {
        private CursoDao _cursoDao;
        public CursoService()
        {
            _cursoDao = new CursoDao();
        }
        public Curso GrabarCurso(Curso curso)
        {
            //Determinara si se trata de un Insert o un Update
            //Para ello usaremos el campo Id de Contact
            //Si Id = 0, siginifica que el Contacto es nuevo (INSERT)
            //Si Id <> 0, siginifica que el Contacto ya existe (UPDATE)

            if(curso.idCurso == 0)
                _cursoDao.InsertarCurso(curso);
            else
                _cursoDao.ActualizarCurso(curso);

            return curso;
        }
        public List<Curso> ObtenerCursos()
        {
            return (List<Curso>)_cursoDao.ObtenerCursos();
        }
        public List<Curso> ObtenerCursosSearch(string searchText)
        {
            return (List<Curso>)_cursoDao.ObtenerCursosSearch(searchText);
        }
        internal IList<Curso> ConsultarCursosConFiltros(Dictionary<string, object> filtros)
        {
            return _cursoDao.GetByFilters(filtros);
        }

        public void EliminarCurso(int id)
        {
            _cursoDao.EliminarCurso(id);
        }
        public void BajaLogicaCurso(int id)
        {
            _cursoDao.BajaLogicaCurso(id);
        }
    }
}
