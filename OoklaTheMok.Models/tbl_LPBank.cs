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
    
    public partial class tbl_LPBank
    {
        public int int_LPBankID { get; set; }
        public int int_LearningPlanID { get; set; }
        public int int_AdminID { get; set; }
        public int int_PurposeID { get; set; }
        public int int_CategoryID { get; set; }
        public int int_ActivityFormatID { get; set; }
        public int int_FollowUpID { get; set; }
        public int int_EvaluationMethodID { get; set; }
        public float rl_HoursUsed { get; set; }
        public float rl_CreditsUsed { get; set; }
        public System.DateTime dt_TimeStamp { get; set; }
        public System.DateTime dt_ApplicationDate { get; set; }
    
        public virtual tbl_ActivityFormats tbl_ActivityFormats { get; set; }
        public virtual tbl_Categories tbl_Categories { get; set; }
        public virtual tbl_EvalMethods tbl_EvalMethods { get; set; }
        public virtual tbl_LearningPlan tbl_LearningPlan { get; set; }
        public virtual tbl_Purposes tbl_Purposes { get; set; }
    }
}
