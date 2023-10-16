using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace G5_ProgramacionAvanzada.Entities
{
    public class UsuarioEnt
    {
        public int Nombre { get; set; }
        public int Username { get; set; }
        public int Correo { get; set; }
        public int Contrasenna { get; set; }
    }
}