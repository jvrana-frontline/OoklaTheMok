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
    
    public partial class tbl_HostSubSections
    {
        public int int_HostSubSectionID { get; set; }
        public int int_HostSectionID { get; set; }
        public string var_SubSectionName { get; set; }
        public string var_SubSectionType { get; set; }
        public int int_Order { get; set; }
    
        public virtual tbl_HostSections tbl_HostSections { get; set; }
    }
}
