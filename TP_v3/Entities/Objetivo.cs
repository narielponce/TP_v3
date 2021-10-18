using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_v3.Entities
{
    public class Objetivo
    {
        public int idObjetivo { get; set; }
        public string nombreCorto { get; set; }
        public string nombreLargo { get; set; }
        public bool borrado { get; set; }

    }
}
