//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dios_mio.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class RetencionISR
    {
        public int idRetencionISR { get; set; }
        public float RetencionEmpleado { get; set; }
        public System.DateTime fechaRetencion { get; set; }
        public int idEmpleado { get; set; }
    
        public virtual Empleado Empleado { get; set; }
    }
}
