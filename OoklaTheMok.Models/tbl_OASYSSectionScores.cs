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
    
    public partial class tbl_OASYSSectionScores
    {
        public int int_FormID { get; set; }
        public int int_UserID { get; set; }
        public int int_InstanceID { get; set; }
        public int int_EvaluationID { get; set; }
        public int int_SectionID { get; set; }
        public Nullable<decimal> dec_Score { get; set; }
        public Nullable<decimal> dec_MaxScore { get; set; }
        public string nvar_Rating { get; set; }
        public Nullable<decimal> dec_CompositeScore { get; set; }
    
        public virtual tbl_OASYSEvaluations tbl_OASYSEvaluations { get; set; }
        public virtual tbl_OASYSForms tbl_OASYSForms { get; set; }
        public virtual tbl_OASYSSections tbl_OASYSSections { get; set; }
        public virtual tbl_UserProfile tbl_UserProfile { get; set; }
    }
}
