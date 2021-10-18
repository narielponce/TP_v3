using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_v3.Entities
{
    public class Curso
    {
        public int idCurso { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public DateTime fechaVigencia { get; set; }
        //public int idCategoria { get; set; }
        public Categoria idCategoria { get; set; }
        public bool borrado { get; set; }
        public override string ToString()
        {
            return nombre;

        }
    }
}
