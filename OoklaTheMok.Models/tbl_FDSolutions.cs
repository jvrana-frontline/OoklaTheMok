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
    
    public partial class tbl_FDSolutions
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_FDSolutions()
        {
            this.tbl_FDFolders = new HashSet<tbl_FDFolders>();
        }
    
        public long int_FDSolutionId { get; set; }
        public string nvar_Name { get; set; }
        public string nvar_Description { get; set; }
        public System.DateTime dt_CreatedAt { get; set; }
        public Nullable<System.DateTime> dt_UpdateAt { get; set; }
        public Nullable<long> int_Position { get; set; }
        public Nullable<bool> bit_IsDefault { get; set; }
        public string nvar_Code { get; set; }
        public string nvar_HelpDeskBaseURL { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_FDFolders> tbl_FDFolders { get; set; }
    }
}
