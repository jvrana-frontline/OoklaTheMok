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
    
    public partial class tbl_TeachingStandards
    {
        public int int_TeachingStandardID { get; set; }
        public string var_TeachingStandardName { get; set; }
        public string var_TeachingStandardDesc { get; set; }
        public bool bit_Active { get; set; }
        public int int_Order { get; set; }
        public string var_State { get; set; }
        public int int_DistrictID { get; set; }
        public string var_Code { get; set; }
    
        public virtual tbl_Districts tbl_Districts { get; set; }
    }
}
