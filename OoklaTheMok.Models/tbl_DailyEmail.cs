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
    
    public partial class tbl_DailyEmail
    {
        public int int_DailyEmailID { get; set; }
        public int int_UserID { get; set; }
        public int int_Type { get; set; }
        public int int_ID { get; set; }
        public string txt_HTML { get; set; }
        public int int_AMID { get; set; }
        public int int_LPMID { get; set; }
    
        public virtual tbl_UserProfile tbl_UserProfile { get; set; }
    }
}
