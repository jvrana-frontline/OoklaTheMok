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
    
    public partial class tbl_WebRegDistrictSettings
    {
        public int int_DistrictId { get; set; }
        public string var_UrlNickName { get; set; }
        public string var_TitleText { get; set; }
        public string var_DistrictUrl { get; set; }
    
        public virtual tbl_Districts tbl_Districts { get; set; }
    }
}