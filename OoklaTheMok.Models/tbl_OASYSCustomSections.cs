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
    
    public partial class tbl_OASYSCustomSections
    {
        public int int_CustomSectionID { get; set; }
        public int int_DistrictID { get; set; }
        public int int_AddedBy { get; set; }
        public System.DateTime dt_AddedDate { get; set; }
        public bool bit_IsDeleted { get; set; }
        public string nvar_Config { get; set; }
        public string nvar_SectionName { get; set; }
    
        public virtual tbl_Districts tbl_Districts { get; set; }
    }
}
