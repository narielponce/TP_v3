using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_v3.DataAccessLayer;
using TP_v3.Entities;

namespace TP_v3.BussinesLayer
{
    public class CategoriaService
    {
        private CategoriaDao _categoriaDao;
        public CategoriaService()
        {
            _categoriaDao = new CategoriaDao();
        }
        public Categoria GrabarCategoria(Categoria categoria)
        {
            //Determinara si se trata de un Insert o un Update
            //Para ello usaremos el campo Id de Contact
            //Si Id = 0, siginifica que el Contacto es nuevo (INSERT)
            //Si Id <> 0, siginifica que el Contacto ya existe (UPDATE)

            if (categoria.idCategoria == 0)
                _categoriaDao.InsertarCategoria(categoria);
            else
                _categoriaDao.ActualizarCategoria(categoria);

            return categoria;
        }
        public List<Categoria> ObtenerCategorias(string searchText = null)
        {
            return (List<Categoria>)_categoriaDao.ObtenerCategorias(searchText);
        }
        public void EliminarCategoria(int id)
        {
            _categoriaDao.EliminarCategoria(id);
        }
    }
}
