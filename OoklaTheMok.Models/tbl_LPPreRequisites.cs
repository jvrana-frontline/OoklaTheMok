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
    
    public partial class tbl_LPPreRequisites
    {
        public int int_LPPreRequisites { get; set; }
        public int int_LearningPlanID { get; set; }
        public int int_PRCourseCodeID { get; set; }
    
        public virtual tbl_LearningPlan tbl_LearningPlan { get; set; }
    }
}