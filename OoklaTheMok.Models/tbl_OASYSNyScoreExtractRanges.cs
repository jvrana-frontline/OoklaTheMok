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
    
    public partial class tbl_OASYSNyScoreExtractRanges
    {
        public int int_ID { get; set; }
        public int int_ConfigID { get; set; }
        public decimal dec_RangeMin { get; set; }
        public decimal dec_RangeMax { get; set; }
        public string nvar_RangeTitle { get; set; }
    
        public virtual tbl_OASYSNyScoreExtractConfig tbl_OASYSNyScoreExtractConfig { get; set; }
    }
}
