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
    
    public partial class tbl_Regions
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Regions()
        {
            this.tbl_Districts1 = new HashSet<tbl_Districts>();
        }
    
        public int int_RegionID { get; set; }
        public int int_RegionOwner { get; set; }
        public string nvar_RegionName { get; set; }
        public bool bit_IsActive { get; set; }
        public bool bit_IsDeleted { get; set; }
        public System.DateTime dt_DateCreated { get; set; }
    
        public virtual tbl_Districts tbl_Districts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Districts> tbl_Districts1 { get; set; }
    }
}