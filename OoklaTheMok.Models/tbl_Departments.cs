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
    
    public partial class tbl_Departments
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Departments()
        {
            this.tbl_ADepartments = new HashSet<tbl_ADepartments>();
            this.tbl_CalDepartments = new HashSet<tbl_CalDepartments>();
            this.tbl_LPDepartments = new HashSet<tbl_LPDepartments>();
            this.tbl_UDepartments = new HashSet<tbl_UDepartments>();
        }
    
        public int int_DepartmentID { get; set; }
        public int int_DistrictID { get; set; }
        public string var_DepartmentName { get; set; }
        public int int_DepartmentChair { get; set; }
        public int int_UserID { get; set; }
        public int int_AdminID { get; set; }
        public string var_DepartmentCode { get; set; }
        public int int_Admin2ID { get; set; }
        public bool bit_Active { get; set; }
        public int int_Order { get; set; }
        public int int_Admin3ID { get; set; }
        public int int_Admin4ID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_ADepartments> tbl_ADepartments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CalDepartments> tbl_CalDepartments { get; set; }
        public virtual tbl_Districts tbl_Districts { get; set; }
        public virtual tbl_UserProfile tbl_UserProfile { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_LPDepartments> tbl_LPDepartments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_UDepartments> tbl_UDepartments { get; set; }
    }
}