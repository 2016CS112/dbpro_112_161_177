//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IMS_nw_dbms.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Fee
    {
        public int FId { get; set; }
        public int SId { get; set; }
        public int CId { get; set; }
        public bool Status { get; set; }
    
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}