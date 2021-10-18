using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_v3.DataAccessLayer;
using TP_v3.Entities;

namespace TP_v3.BussinesLayer
{
    public class ObjetivoService
    {
        private ObjetivoDao _objetivoDao;
            public ObjetivoService()
        {
            _objetivoDao = new ObjetivoDao();
        }
        public Objetivo GrabarObjetivo(Objetivo objetivo)
        {
            //Determinara si se trata de un Insert o un Update
            //Para ello usaremos el campo Id de Contact
            //Si Id = 0, siginifica que el Contacto es nuevo (INSERT)
            //Si Id <> 0, siginifica que el Contacto ya existe (UPDATE)

            if (objetivo.idObjetivo == 0)
                _objetivoDao.InsertarObjetivo(objetivo);
            else
                _objetivoDao.ActualizarObjetivo(objetivo);

            return objetivo;
        }
        public List<Objetivo> ObtenerObjetivos(string searchText = null)
        {
            return (List<Objetivo>)_objetivoDao.ObtenerObjetivos(searchText);
        }
        public void EliminarObjetivo(int id)
        {
            _objetivoDao.EliminarObjetivo(id);
        }

    }
}
