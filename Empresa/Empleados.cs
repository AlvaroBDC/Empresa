//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Empresa
{
    using System;
    using System.Collections.Generic;
    
    public partial class Empleados
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public Nullable<decimal> sueldo_bruto { get; set; }
        public string categoria { get; set; }
        public Nullable<decimal> monto_aumento { get; set; }
        public Nullable<decimal> sueldo_neto { get; set; }
    }
}
