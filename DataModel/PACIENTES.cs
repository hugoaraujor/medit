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
    
    public partial class PACIENTES
    {
        public long PACIENTEID { get; set; }
        public string IDENTIFICACION { get; set; }
        public string NOMBRES { get; set; }
        public string APELLIDOS { get; set; }
        public System.DateTime FECHANAC { get; set; }
        public int TIPO { get; set; }
        public string DIRECCION { get; set; }
        public Nullable<int> EMPRESA { get; set; }
        public Nullable<int> ASEGURADORA { get; set; }
        public Nullable<int> EDOCIVIL { get; set; }
        public string NOMBRECONYUGUE { get; set; }
        public string TELEFONO { get; set; }
        public string TELEFONO2 { get; set; }
        public string MOVIL { get; set; }
        public Nullable<int> CARGO { get; set; }
        public string EQUIPO { get; set; }
        public string ARCHIVOCEDULA { get; set; }
        public int SEXO { get; set; }
        public int EDAD { get; set; }
        public byte[] CREATED { get; set; }
        public Nullable<System.DateTime> ULTIMAVISITA { get; set; }
        public int CIUDAD { get; set; }
        public int ESTADO { get; set; }
        public string NACIONALIDAD { get; set; }
        public string OBSERVACIONES { get; set; }
        public string FICHALABORAL { get; set; }
        public string SECTOR { get; set; }
        public Nullable<int> ASEGURADORA2 { get; set; }
    }
}