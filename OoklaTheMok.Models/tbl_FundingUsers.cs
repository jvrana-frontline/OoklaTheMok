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
    
    public partial class tbl_FundingUsers
    {
        public int int_FundingUserID { get; set; }
        public int int_FundingSourceID { get; set; }
        public bool bit_View { get; set; }
        public bool bit_Use { get; set; }
        public bool bit_Delete { get; set; }
        public int int_AdminID { get; set; }
    
        public virtual tbl_FundingSources tbl_FundingSources { get; set; }
        public virtual tbl_UserProfile tbl_UserProfile { get; set; }
    }
}
