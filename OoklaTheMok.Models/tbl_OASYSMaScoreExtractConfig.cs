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
    
    public partial class tbl_OASYSMaScoreExtractConfig
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_OASYSMaScoreExtractConfig()
        {
            this.tbl_OASYSMaScoreExtractCriteria = new HashSet<tbl_OASYSMaScoreExtractCriteria>();
        }
    
        public int int_ID { get; set; }
        public int int_DistrictID { get; set; }
        public System.DateTime dt_StartDate { get; set; }
        public System.DateTime dt_EndDate { get; set; }
        public string var_Name { get; set; }
    
        public virtual tbl_Districts tbl_Districts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_OASYSMaScoreExtractCriteria> tbl_OASYSMaScoreExtractCriteria { get; set; }
    }
}
