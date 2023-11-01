using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Entities
{
    public class UsuarioEnt
    {

        public int ConUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public string Contrasenna { get; set; }
        public bool Estado { get; set; }
        public string Rol { get; set; }

    }
}