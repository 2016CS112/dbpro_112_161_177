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
    
    public partial class Result
    {
        public int RId { get; set; }
        public int SId { get; set; }
        public int InId { get; set; }
        public int Id { get; set; }
    
        public virtual Instructor Instructor { get; set; }
        public virtual MCQ MCQ { get; set; }
        public virtual Student Student { get; set; }
    }
}