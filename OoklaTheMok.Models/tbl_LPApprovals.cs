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
    
    public partial class tbl_LPApprovals
    {
        public int int_LPApprovalID { get; set; }
        public int int_LearningPlanID { get; set; }
        public int int_UserID { get; set; }
        public string var_Title { get; set; }
        public Nullable<System.DateTime> dt_Date { get; set; }
        public string var_AdminComment { get; set; }
        public string var_Comment { get; set; }
        public string var_ApprovalType { get; set; }
        public string var_Status { get; set; }
        public int int_Order { get; set; }
        public string var_EmailTo { get; set; }
    
        public virtual tbl_LearningPlan tbl_LearningPlan { get; set; }
        public virtual tbl_UserProfile tbl_UserProfile { get; set; }
    }
}
