//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OoklaTheMok.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_AUsers
    {
        public int int_AUserID { get; set; }
        public int int_ActivityID { get; set; }
        public int int_TargetUserID { get; set; }
    
        public virtual tbl_Activities tbl_Activities { get; set; }
    }
}
