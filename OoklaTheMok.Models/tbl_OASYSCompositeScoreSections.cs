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
    
    public partial class tbl_OASYSCompositeScoreSections
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_OASYSCompositeScoreSections()
        {
            this.tbl_OASYSCompositeScoreCriteria = new HashSet<tbl_OASYSCompositeScoreCriteria>();
            this.tbl_OASYSCompositeScoreRanges = new HashSet<tbl_OASYSCompositeScoreRanges>();
        }
    
        public int int_SectionID { get; set; }
        public string nvar_Title { get; set; }
        public int int_DecimalPlaces { get; set; }
        public bool bit_ApplyPrecisionToCriteria { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_OASYSCompositeScoreCriteria> tbl_OASYSCompositeScoreCriteria { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_OASYSCompositeScoreRanges> tbl_OASYSCompositeScoreRanges { get; set; }
        public virtual tbl_OASYSSections tbl_OASYSSections { get; set; }
    }
}
