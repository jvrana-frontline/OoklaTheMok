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
    
    public partial class tbl_FormTemplates
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_FormTemplates()
        {
            this.tbl_FormTemplateData = new HashSet<tbl_FormTemplateData>();
        }
    
        public int int_FormTemplateID { get; set; }
        public int int_FormID { get; set; }
        public string var_Name { get; set; }
        public string var_Description { get; set; }
        public bool bit_Active { get; set; }
        public bool bit_DistrictConfigOnly { get; set; }
        public bool bit_DistrictAdminOnly { get; set; }
        public string var_Group { get; set; }
    
        public virtual tbl_Forms tbl_Forms { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_FormTemplateData> tbl_FormTemplateData { get; set; }
    }
}
