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
    
    public partial class tbl_GroupUsers
    {
        public int int_GroupUserID { get; set; }
        public int int_GroupID { get; set; }
        public int int_UserID { get; set; }
    
        public virtual tbl_Groups tbl_Groups { get; set; }
    }
}
