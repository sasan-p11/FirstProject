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
    
    public partial class User
    {
        public int UserId { get; set; }
        public string Gender { get; set; }
        public string FirstName { get; set; }
        public string Family { get; set; }
        public Nullable<int> Age { get; set; }
        public Nullable<System.DateTime> RegisterDate { get; set; }
    
        public virtual Login Login { get; set; }
    }
}