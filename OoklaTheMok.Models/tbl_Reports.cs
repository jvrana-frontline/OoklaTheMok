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
    
    public partial class tbl_Reports
    {
        public int int_ReportID { get; set; }
        public string var_ReportName { get; set; }
        public bool bit_Public { get; set; }
        public bool bit_MLP { get; set; }
        public bool bit_WebReg { get; set; }
        public int int_DistrictID { get; set; }
        public int int_UserID { get; set; }
        public bool bit_DateTime { get; set; }
        public string var_SQL { get; set; }
        public int int_Order { get; set; }
        public string var_Join { get; set; }
        public string var_Group { get; set; }
        public string var_Field { get; set; }
        public string var_Table { get; set; }
        public string var_Sort { get; set; }
        public string var_Filter { get; set; }
        public string var_Operator { get; set; }
        public string var_FilterSelect { get; set; }
        public string var_Value { get; set; }
        public string var_Group0 { get; set; }
        public int int_SortCol { get; set; }
        public int int_SortColID { get; set; }
        public bool bit_Template1 { get; set; }
        public bool bit_Template2 { get; set; }
        public bool bit_Template3 { get; set; }
        public bool bit_Template4 { get; set; }
        public bool bit_SQLOverride { get; set; }
        public string var_HTMLHeader { get; set; }
        public string var_HTMLFooter { get; set; }
        public string var_Format { get; set; }
        public bool bit_Template5 { get; set; }
        public bool bit_Template6 { get; set; }
        public bool bit_LockReportDesign { get; set; }
        public string var_LeftNav { get; set; }
        public string var_ShortName { get; set; }
        public bool bit_ContentCustomer { get; set; }
    
        public virtual tbl_Districts tbl_Districts { get; set; }
        public virtual tbl_UserProfile tbl_UserProfile { get; set; }
    }
}
