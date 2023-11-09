﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Entities
{
    public class ToursEnt
    {
        public long ID { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string imagen { get; set; }
        public decimal  { get; set; }
        public int IdEstado { get; set; }
        public int IdPais { get; set; }
        public long IdDestino { get; set; }
}
}