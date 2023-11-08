using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace G5_ProgramacionAvanzada.Entities
{
    public class CarrosEnt
    {
        public string marca { get; set; }
        public string modelo { get; set; }
        public int annio { get; set; }
        public decimal precio { get; set; }
        public string imagen { get; set; }
        public int IdPais { get; set; }
        public int IdEstado { get; set; }
    }
}