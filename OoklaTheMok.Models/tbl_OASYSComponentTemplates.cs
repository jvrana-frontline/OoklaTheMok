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
    
    public partial class tbl_OASYSComponentTemplates
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_OASYSComponentTemplates()
        {
            this.tbl_OASYSComponentTemplateForms = new HashSet<tbl_OASYSComponentTemplateForms>();
        }
    
        public int int_ComponentID { get; set; }
        public string nvar_ComponentTitle { get; set; }
        public int int_DistrictID { get; set; }
        public bool bit_IsShared { get; set; }
        public bool bit_IsDeleted { get; set; }
        public int int_Index { get; set; }
        public bool bit_RequiresAcknowledgment { get; set; }
    
        public virtual tbl_Districts tbl_Districts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_OASYSComponentTemplateForms> tbl_OASYSComponentTemplateForms { get; set; }
    }
}
