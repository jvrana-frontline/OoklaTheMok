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
    
    public partial class tbl_OASYSEmployeeClassifications
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_OASYSEmployeeClassifications()
        {
            this.tbl_OASYSTypes = new HashSet<tbl_OASYSTypes>();
        }
    
        public int int_EmployeeClassificationID { get; set; }
        public string nvar_Title { get; set; }
        public string nvar_Description { get; set; }
        public bool bit_Active { get; set; }
        public int int_DistrictID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_OASYSTypes> tbl_OASYSTypes { get; set; }
    }
}