using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Entities
{
    public class UsuarioEnt
    {

        public int IdUser { get; set; }
        public string username { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string email { get; set; }
        public string contrasenna { get; set; }
        public int IdEstado { get; set; }
        public int IdRol { get; set; }

    }
}