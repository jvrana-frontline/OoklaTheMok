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
    
    public partial class tbl_OASYSCompositeScoreRanges
    {
        public int int_RangeID { get; set; }
        public int int_CompositeScoreSectionID { get; set; }
        public string nvar_RangeTitle { get; set; }
        public decimal dec_RangeMin { get; set; }
        public decimal dec_RangeMax { get; set; }
        public string nvar_BackgroundColor { get; set; }
    
        public virtual tbl_OASYSCompositeScoreSections tbl_OASYSCompositeScoreSections { get; set; }
    }
}