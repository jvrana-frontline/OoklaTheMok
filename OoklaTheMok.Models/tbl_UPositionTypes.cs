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
    
    public partial class tbl_UPositionTypes
    {
        public int int_UPositionTypeID { get; set; }
        public int int_UserID { get; set; }
        public int int_PositionTypeID { get; set; }
        public int int_WebRegID { get; set; }
    
        public virtual tbl_UserProfile tbl_UserProfile { get; set; }
    }
}