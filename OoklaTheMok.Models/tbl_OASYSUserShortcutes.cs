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
    
    public partial class tbl_OASYSUserShortcutes
    {
        public int int_ShortcutID { get; set; }
        public Nullable<int> int_UserID { get; set; }
        public string var_Name { get; set; }
        public string var_Value { get; set; }
        public bool bit_IsDeleted { get; set; }
    
        public virtual tbl_UserProfile tbl_UserProfile { get; set; }
    }
}