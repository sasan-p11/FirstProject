//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FirstProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class error
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string type_error { get; set; }
        public int id_tile { get; set; }
        public System.DateTime time_stamp { get; set; }
    
        public virtual tile tile { get; set; }
    }
}