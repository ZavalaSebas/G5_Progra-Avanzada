﻿namespace G5_ProgramacionAvanzada.Entities
{
    public class UsuarioEnt
    {
        public int IDUser { get; set; }
        public string Username { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public string Contrasenna { get; set; }
        public int IDRol { get; set; }
    }
}