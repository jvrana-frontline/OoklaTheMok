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
    
    public partial class tbl_OASYSImportTemplates
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_OASYSImportTemplates()
        {
            this.tbl_OASYSImportTemplateSections = new HashSet<tbl_OASYSImportTemplateSections>();
        }
    
        public int int_TemplateId { get; set; }
        public int int_DistrictID { get; set; }
        public int int_CreatedBy { get; set; }
        public System.DateTime dt_DateCreated { get; set; }
        public string nvar_Name { get; set; }
        public string nvar_Description { get; set; }
        public Nullable<System.DateTime> dt_StartDate { get; set; }
        public Nullable<System.DateTime> dt_EndDate { get; set; }
    
        public virtual tbl_Districts tbl_Districts { get; set; }
        public virtual tbl_UserProfile tbl_UserProfile { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_OASYSImportTemplateSections> tbl_OASYSImportTemplateSections { get; set; }
    }
}
