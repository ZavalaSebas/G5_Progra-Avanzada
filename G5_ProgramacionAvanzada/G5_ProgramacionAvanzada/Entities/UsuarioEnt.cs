using System;

namespace G5_ProgramacionAvanzada.Entities
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

    public class RolEnt
    {
        public int ID { get; set; }
        public string nombre { get; set; }
        
    }

    public class ReservaEnt
    {
        public int ID { get; set; }
        public int type { get; set; }
        public int IDUser { get; set; }
        public int IDDestino { get; set; }
        public DateTime salida { get; set; }
        public DateTime entrada { get; set; }

    }

    public class HotelesEnt
    {
        public int ID { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string pais { get; set; }

    }
}