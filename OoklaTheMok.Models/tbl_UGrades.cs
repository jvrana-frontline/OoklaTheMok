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
    
    public partial class tbl_UGrades
    {
        public int int_UGradeID { get; set; }
        public Nullable<int> int_UserID { get; set; }
        public Nullable<int> int_GradeID { get; set; }
    
        public virtual tbl_Grades tbl_Grades { get; set; }
        public virtual tbl_UserProfile tbl_UserProfile { get; set; }
    }
}