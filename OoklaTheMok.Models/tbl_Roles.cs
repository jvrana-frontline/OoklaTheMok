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
    
    public partial class tbl_Roles
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Roles()
        {
            this.tbl_UserProfile = new HashSet<tbl_UserProfile>();
        }
    
        public int int_RoleId { get; set; }
        public string var_Name { get; set; }
        public string var_Code { get; set; }
        public Nullable<int> int_DistrictId { get; set; }
        public int int_Order { get; set; }
        public bool bit_Active { get; set; }
    
        public virtual tbl_Districts tbl_Districts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_UserProfile> tbl_UserProfile { get; set; }
    }
}