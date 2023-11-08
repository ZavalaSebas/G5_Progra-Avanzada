using System;

namespace G5_ProgramacionAvanzada.Entities
{
    public class HotelesEnt
    {
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string descripcion { get; set; }
        public decimal precio { get; set; }
        public string imagen { get; set; }
        public int IdAmenidades { get; set; }
        public int IdPais { get; set; }
        public int IdEstado { get; set; }

    }
}