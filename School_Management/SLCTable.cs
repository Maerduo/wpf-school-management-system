//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace School_Management
{
    using System;
    using System.Collections.Generic;
    
    public partial class SLCTable
    {
        public int SLCId { get; set; }
        public Nullable<int> AdmissionNumber { get; set; }
        public Nullable<System.DateTime> DateIssued { get; set; }
        public string IssuedOnce { get; set; }
    
        public virtual StudentTable StudentTable { get; set; }
    }
}
