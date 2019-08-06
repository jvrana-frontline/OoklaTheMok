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
    
    public partial class tbl_Files
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Files()
        {
            this.tbl_Plans = new HashSet<tbl_Plans>();
            this.tbl_UResumes = new HashSet<tbl_UResumes>();
        }
    
        public int int_FileID { get; set; }
        public int int_DistrictID { get; set; }
        public int int_UserID { get; set; }
        public string var_Filename { get; set; }
        public string var_Title { get; set; }
        public int int_FileSizeInBytes { get; set; }
        public System.DateTime dt_DateSubmitted { get; set; }
        public string var_ImagePath { get; set; }
        public bool bit_Archive { get; set; }
        public int int_ActivityID { get; set; }
        public int int_FileTypeID { get; set; }
    
        public virtual tbl_Activities tbl_Activities { get; set; }
        public virtual tbl_Districts tbl_Districts { get; set; }
        public virtual tbl_FileTypes tbl_FileTypes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Plans> tbl_Plans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_UResumes> tbl_UResumes { get; set; }
    }
}
