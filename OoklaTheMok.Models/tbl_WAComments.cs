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
    
    public partial class tbl_WAComments
    {
        public int int_WACommentID { get; set; }
        public int int_UserID { get; set; }
        public string var_Comment { get; set; }
        public System.DateTime dt_Date { get; set; }
    
        public virtual tbl_UserProfile tbl_UserProfile { get; set; }
    }
}
