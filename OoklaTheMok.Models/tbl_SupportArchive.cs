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
    
    public partial class tbl_SupportArchive
    {
        public int int_SupportArchiveID { get; set; }
        public int int_UserID { get; set; }
        public int int_DistrictID { get; set; }
        public string var_Email { get; set; }
        public string var_Type { get; set; }
        public string var_Feature { get; set; }
        public string var_Text { get; set; }
        public string var_HelpIDsViewed { get; set; }
        public Nullable<System.DateTime> dt_Open { get; set; }
        public Nullable<System.DateTime> dt_Closed { get; set; }
        public string var_CurrentStatus { get; set; }
        public string var_SupportInitials { get; set; }
        public string var_ResponseText { get; set; }
    
        public virtual tbl_Districts tbl_Districts { get; set; }
        public virtual tbl_UserProfile tbl_UserProfile { get; set; }
    }
}
