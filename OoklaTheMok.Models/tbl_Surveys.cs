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
    
    public partial class tbl_Surveys
    {
        public int int_SurveyID { get; set; }
        public int int_FormID { get; set; }
        public int int_UserID { get; set; }
        public int int_DistrictID { get; set; }
        public int int_ActivityID { get; set; }
        public int int_LearningPlanID { get; set; }
        public int int_BuildingID { get; set; }
        public string var_Response1 { get; set; }
        public string var_Response2 { get; set; }
        public string var_Response3 { get; set; }
        public string var_Response4 { get; set; }
        public string var_Response5 { get; set; }
        public string var_Response6 { get; set; }
        public string var_Response7 { get; set; }
        public string var_Response8 { get; set; }
        public string var_Response9 { get; set; }
        public string var_Response10 { get; set; }
        public string var_Response11 { get; set; }
        public string var_Response12 { get; set; }
        public string var_Response13 { get; set; }
        public string var_Response14 { get; set; }
        public string var_Response15 { get; set; }
        public string var_Response16 { get; set; }
        public string var_Response17 { get; set; }
        public string var_Response18 { get; set; }
        public string var_Response19 { get; set; }
        public string var_Response20 { get; set; }
        public string var_Response21 { get; set; }
        public string var_Response22 { get; set; }
        public string var_Response23 { get; set; }
        public string var_Response24 { get; set; }
        public string var_Response25 { get; set; }
        public string var_Response26 { get; set; }
        public string var_Response27 { get; set; }
        public string var_Response28 { get; set; }
        public string var_Response29 { get; set; }
        public string var_Response30 { get; set; }
        public string var_Response31 { get; set; }
        public string var_Response32 { get; set; }
        public string var_Response33 { get; set; }
        public string var_Response34 { get; set; }
        public string var_Response35 { get; set; }
        public string var_Response36 { get; set; }
        public string var_Response37 { get; set; }
        public string var_Response38 { get; set; }
        public string var_Response39 { get; set; }
        public string var_Response40 { get; set; }
        public string var_Response41 { get; set; }
        public string var_Response42 { get; set; }
        public string var_Response43 { get; set; }
        public string var_Response44 { get; set; }
        public string var_Response45 { get; set; }
        public string var_Response46 { get; set; }
        public string var_Response47 { get; set; }
        public string var_Response48 { get; set; }
        public string var_Response49 { get; set; }
        public string var_Response50 { get; set; }
        public System.DateTime dt_DateSent { get; set; }
        public System.DateTime dt_DateSubmitted { get; set; }
        public bool bit_Archived { get; set; }
        public Nullable<System.DateTime> dt_LastUpdated { get; set; }
    
        public virtual tbl_Districts tbl_Districts { get; set; }
        public virtual tbl_UserProfile tbl_UserProfile { get; set; }
    }
}
