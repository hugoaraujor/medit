//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class medicinas
    {
        public int id { get; set; }
        public string medicamento { get; set; }
        public string presentacion { get; set; }
        public string indicaciones { get; set; }
        public Nullable<bool> activo { get; set; }
        public Nullable<int> via { get; set; }
    }
}
