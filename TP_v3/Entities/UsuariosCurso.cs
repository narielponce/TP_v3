using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_v3.Entities
{
    public class UsuariosCurso
    {
        public Usuario IdUsuario { get; set; }
        public Curso IdCurso { get; set; }
        public int Puntuacion { get; set; }
        public string Observacion { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fin { get; set; }
    }
}
