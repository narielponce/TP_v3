using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_v3.Entities
{
    public class UsuariosCursoAvance
    {
        public Usuario idUsuario { get; set; }
        public Curso idCurso { get; set; }
        public DateTime inicio { get; set; }
        public DateTime fin { get; set; }
        public int porcAvance { get; set; }
    }
}
