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
    
    public partial class tbl_OASYSNyScoreExtractCriteria
    {
        public int int_ID { get; set; }
        public int int_TypeID { get; set; }
        public int int_SectionID { get; set; }
        public int int_ScoreType { get; set; }
        public Nullable<int> int_ConfigID { get; set; }
        public bool bit_IsTransitional { get; set; }
    
        public virtual tbl_OASYSNyScoreExtractCriteria tbl_OASYSNyScoreExtractCriteria1 { get; set; }
        public virtual tbl_OASYSNyScoreExtractCriteria tbl_OASYSNyScoreExtractCriteria2 { get; set; }
        public virtual tbl_OASYSTypes tbl_OASYSTypes { get; set; }
    }
}