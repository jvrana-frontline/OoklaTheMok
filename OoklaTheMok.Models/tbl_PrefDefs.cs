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
    
    public partial class tbl_PrefDefs
    {
        public int int_PrefDefID { get; set; }
        public string var_Name { get; set; }
        public string var_Group { get; set; }
        public string var_Description { get; set; }
        public bool bit_ForDistrict { get; set; }
        public bool bit_ForUser { get; set; }
        public string var_Type { get; set; }
        public string var_SQLList { get; set; }
        public string var_TextValueList { get; set; }
        public int int_Order { get; set; }
        public bool bit_SysAdminOnly { get; set; }
    }
}
