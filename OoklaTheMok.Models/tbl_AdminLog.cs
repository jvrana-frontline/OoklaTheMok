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
    
    public partial class tbl_AdminLog
    {
        public int int_AdminLogID { get; set; }
        public Nullable<int> int_UserID { get; set; }
        public Nullable<int> int_ActivityID { get; set; }
        public Nullable<int> int_LearningPlanID { get; set; }
        public Nullable<int> int_DistrictID { get; set; }
        public string var_Type { get; set; }
        public string var_Description { get; set; }
        public string var_Status { get; set; }
        public string var_Notes { get; set; }
        public System.DateTime dt_TimeStamp { get; set; }
        public int int_SupportID { get; set; }
    
        public virtual tbl_Activities tbl_Activities { get; set; }
    }
}
