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
    
    public partial class tbl_OASYSArchiveFormsRequest
    {
        public int int_RequestID { get; set; }
        public int int_DistrictID { get; set; }
        public int int_UserID { get; set; }
        public System.DateTime dt_DateRequested { get; set; }
        public Nullable<System.DateTime> dt_DateCompleted { get; set; }
        public string nvar_FileName { get; set; }
        public string nvar_FileLocation { get; set; }
        public string nvar_Request { get; set; }
        public System.Guid guid_Key { get; set; }
        public Nullable<int> int_Status { get; set; }
    
        public virtual tbl_Districts tbl_Districts { get; set; }
        public virtual tbl_UserProfile tbl_UserProfile { get; set; }
    }
}