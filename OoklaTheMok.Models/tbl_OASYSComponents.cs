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
    
    public partial class tbl_OASYSComponents
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_OASYSComponents()
        {
            this.tbl_OASYSComponentForms = new HashSet<tbl_OASYSComponentForms>();
            this.tbl_OASYSComponentUserRights = new HashSet<tbl_OASYSComponentUserRights>();
            this.tbl_OASYSUserComponentExceptions = new HashSet<tbl_OASYSUserComponentExceptions>();
            this.tbl_OASYSUserComponents = new HashSet<tbl_OASYSUserComponents>();
        }
    
        public int int_ComponentID { get; set; }
        public int int_TypeID { get; set; }
        public string nvar_ComponentTitle { get; set; }
        public int int_DistrictID { get; set; }
        public bool bit_IsShared { get; set; }
        public bool bit_IsDeleted { get; set; }
        public int int_Index { get; set; }
        public bool bit_RequiresAcknowledgment { get; set; }
        public bool bit_DefaultToZeroInstances { get; set; }
    
        public virtual tbl_Districts tbl_Districts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_OASYSComponentForms> tbl_OASYSComponentForms { get; set; }
        public virtual tbl_OASYSTypes tbl_OASYSTypes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_OASYSComponentUserRights> tbl_OASYSComponentUserRights { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_OASYSUserComponentExceptions> tbl_OASYSUserComponentExceptions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_OASYSUserComponents> tbl_OASYSUserComponents { get; set; }
    }
}
