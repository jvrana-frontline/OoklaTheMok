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
    
    public partial class tbl_OASYSEvaluationApprovals
    {
        public int int_EvaluationID { get; set; }
        public int int_TypeID { get; set; }
        public System.DateTime dt_StartDate { get; set; }
        public System.DateTime dt_EndDate { get; set; }
        public int int_SubmittedBy { get; set; }
        public System.DateTime dt_DateSubmitted { get; set; }
        public bool bit_IsApproved { get; set; }
        public Nullable<System.DateTime> dt_DateApproved { get; set; }
        public Nullable<int> int_ApprovedBy { get; set; }
    
        public virtual tbl_OASYSEvaluations tbl_OASYSEvaluations { get; set; }
        public virtual tbl_OASYSTypes tbl_OASYSTypes { get; set; }
        public virtual tbl_UserProfile tbl_UserProfile { get; set; }
        public virtual tbl_UserProfile tbl_UserProfile1 { get; set; }
    }
}
