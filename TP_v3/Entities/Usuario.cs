using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_v3.Entities
{
    public class Usuario
    {
        public int idUsuario { get; set; }
        public string nombreUsuario { get; set; }
        public  string email { get; set; }
        public  string password { get; set; }
        public string estado { get; set; }
        public bool borrado { get; set; }
        public Perfil perfil { get; set; }
        public override string ToString()
        {
            return nombreUsuario;
        }
    }
} 
