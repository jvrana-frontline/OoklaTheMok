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
    
    public partial class tbl_LPPurposes
    {
        public int int_LPPurposeID { get; set; }
        public Nullable<int> int_LearningPlanID { get; set; }
        public Nullable<int> int_PurposeID { get; set; }
        public float rl_Units { get; set; }
        public int int_RegEnrollmentTypeID { get; set; }
        public float rl_PHours { get; set; }
        public float rl_PCredits { get; set; }
    
        public virtual tbl_LearningPlan tbl_LearningPlan { get; set; }
        public virtual tbl_Purposes tbl_Purposes { get; set; }
    }
}
