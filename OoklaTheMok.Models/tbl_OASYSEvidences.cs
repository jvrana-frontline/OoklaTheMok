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
    
    public partial class tbl_OASYSEvidences
    {
        public int int_EvidenceID { get; set; }
        public int int_EvidenceCriteriaID { get; set; }
        public string nvar_Name { get; set; }
        public System.DateTime dt_RecordDate { get; set; }
        public int int_AdminID { get; set; }
        public Nullable<System.DateTime> dt_DateSynched { get; set; }
        public Nullable<int> int_SynchAdminID { get; set; }
    
        public virtual tbl_OASYSEvidenceCriteria tbl_OASYSEvidenceCriteria { get; set; }
        public virtual tbl_UserProfile tbl_UserProfile { get; set; }
        public virtual tbl_UserProfile tbl_UserProfile1 { get; set; }
    }
}
