using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_v3.Entities
{
    public class Categoria
    {
        public int idCategoria { get; set; }
        public string nombreCateg { get; set; }
        public string descripcion { get; set; }
        public bool borrado { get; set; }
        public override string ToString()
        {
            return nombreCateg;
        }
    }
}
