using System;

namespace G5_ProgramacionAvanzada.Entities
{
    public class UsuarioEnt
    {
        public int IDUser { get; set; }
        public string username { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string email { get; set; }
        public string contrasenna { get; set; }
        public bool estado { get; set; }
        public long IDRol { get; set; }

    }
}