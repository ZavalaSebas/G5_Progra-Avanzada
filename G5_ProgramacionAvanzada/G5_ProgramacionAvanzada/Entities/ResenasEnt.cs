using System;

namespace G5_ProgramacionAvanzada.Entities
{
    public class ResenaEnt
    {
        public long Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public decimal Puntuacion { get; set; }
        public long? IdUsuario { get; set; }
        public long? IdHotel { get; set; }
    }
}
