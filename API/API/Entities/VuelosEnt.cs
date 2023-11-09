using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace API.Entities
{
    public class VuelosEnt
    {
        [Required]
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }
        public decimal precio { get; set; }
        public int IdPais { get; set; }
        public int IdEstado { get; set; }


    }
}