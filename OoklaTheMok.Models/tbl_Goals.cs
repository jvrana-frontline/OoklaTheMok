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
    
    public partial class tbl_Goals
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Goals()
        {
            this.tbl_Objectives = new HashSet<tbl_Objectives>();
        }
    
        public int int_GoalID { get; set; }
        public int int_DistrictID { get; set; }
        public Nullable<int> int_UserID { get; set; }
        public string var_GoalTitle { get; set; }
        public string var_GoalDesc { get; set; }
        public int int_ImageID { get; set; }
        public bool bit_Active { get; set; }
        public int int_Order { get; set; }
    
        public virtual tbl_Districts tbl_Districts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Objectives> tbl_Objectives { get; set; }
    }
}
