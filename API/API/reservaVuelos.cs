//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace API
{
    using System;
    using System.Collections.Generic;
    
    public partial class reservaVuelos
    {
        public long ID { get; set; }
        public long IdVuelos { get; set; }
        public System.DateTime Fecha { get; set; }
    
        public virtual vuelos vuelos { get; set; }
    }
}
