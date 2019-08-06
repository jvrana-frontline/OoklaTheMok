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
    
    public partial class tbl_Content
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Content()
        {
            this.tbl_ContentStandards = new HashSet<tbl_ContentStandards>();
            this.tbl_LPContent = new HashSet<tbl_LPContent>();
        }
    
        public int int_ContentID { get; set; }
        public int int_ProviderID { get; set; }
        public string var_ContentTitle { get; set; }
        public string var_ContentDesc { get; set; }
        public string var_LMSSectionID { get; set; }
        public string var_IMSSectionID { get; set; }
        public bool bit_Active { get; set; }
        public Nullable<System.DateTime> dt_StopShowing { get; set; }
        public Nullable<System.DateTime> dt_StartDate { get; set; }
        public Nullable<System.DateTime> dt_EndDate { get; set; }
        public string var_URL { get; set; }
        public string var_BundleCode { get; set; }
        public int int_Order { get; set; }
        public float rl_Hours { get; set; }
        public float rl_Credits { get; set; }
        public string var_MeetingsConfig { get; set; }
        public int int_FormTemplateID { get; set; }
        public string var_ContentType { get; set; }
        public string var_ContentNumber { get; set; }
        public string var_ContentSectionID { get; set; }
        public string var_Thumbnail { get; set; }
        public string var_RemoteSysID { get; set; }
        public string var_RemoteSysName { get; set; }
        public Nullable<System.Guid> guid_CollectionID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_ContentStandards> tbl_ContentStandards { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_LPContent> tbl_LPContent { get; set; }
    }
}
