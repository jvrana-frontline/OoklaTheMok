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
    
    public partial class tbl_RegEnrollmentTypes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_RegEnrollmentTypes()
        {
            this.tbl_ARegOptions = new HashSet<tbl_ARegOptions>();
            this.tbl_RegPEnrollmentTypes = new HashSet<tbl_RegPEnrollmentTypes>();
        }
    
        public int int_RegEnrollmentTypeID { get; set; }
        public string var_Name { get; set; }
        public string var_Description { get; set; }
        public string var_CreditType { get; set; }
        public int int_SpecialFunction { get; set; }
        public string var_ShortName { get; set; }
        public string var_CertificateStatement { get; set; }
        public bool bit_Active { get; set; }
        public string var_DistrictIDList { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_ARegOptions> tbl_ARegOptions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_RegPEnrollmentTypes> tbl_RegPEnrollmentTypes { get; set; }
    }
}
