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
    
    public partial class tbl_OASYSForms
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_OASYSForms()
        {
            this.tbl_OASYSComponentForms = new HashSet<tbl_OASYSComponentForms>();
            this.tbl_OASYSComponentTemplateForms = new HashSet<tbl_OASYSComponentTemplateForms>();
            this.tbl_OASYSCriteriaStandardScores = new HashSet<tbl_OASYSCriteriaStandardScores>();
            this.tbl_OASYSEvidenceCriteria = new HashSet<tbl_OASYSEvidenceCriteria>();
            this.tbl_OASYSUserFormComments = new HashSet<tbl_OASYSUserFormComments>();
            this.tbl_OASYSRubricCrtieriaScores = new HashSet<tbl_OASYSRubricCrtieriaScores>();
            this.tbl_OASYSSectionScores = new HashSet<tbl_OASYSSectionScores>();
            this.tbl_OASYSSlos = new HashSet<tbl_OASYSSlos>();
            this.tbl_OASYSUnalignedEvidences = new HashSet<tbl_OASYSUnalignedEvidences>();
            this.tbl_OASYSUserFormEvents = new HashSet<tbl_OASYSUserFormEvents>();
            this.tbl_OASYSUserForms = new HashSet<tbl_OASYSUserForms>();
        }
    
        public int int_FormID { get; set; }
        public int int_DistrictID { get; set; }
        public string nvar_FormName { get; set; }
        public int FormViews { get; set; }
        public Nullable<System.DateTime> sdt_Created { get; set; }
        public Nullable<System.DateTime> sdt_Modified { get; set; }
        public Nullable<System.DateTime> sdt_LastAccessed { get; set; }
        public string nvar_FormType { get; set; }
        public bool IsSystemForm { get; set; }
        public string nvar_URL { get; set; }
        public string nvar_ReturnURL { get; set; }
        public bool bit_IsArchived { get; set; }
        public bool bit_UseApproval { get; set; }
        public bool bit_UseAudit { get; set; }
        public int int_ApprovalLevels { get; set; }
        public bool bit_ViewInFormList { get; set; }
        public string nvar_FormClassName { get; set; }
        public byte[] img_TitleImage { get; set; }
        public bool bit_IsTemp { get; set; }
        public bool bit_IsPublish { get; set; }
        public bool bit_IsGeneralPurpose { get; set; }
        public bool bit_IsGeneralPurposeApproved { get; set; }
        public bool bit_CanChangeLayout { get; set; }
        public bool bit_HasEntries { get; set; }
        public bool bit_IsAdminOnly { get; set; }
        public bool bit_RequiresSchedule { get; set; }
        public bool bit_RequiresScheduleApproval { get; set; }
        public bool bit_IsSchedulable { get; set; }
        public bool bit_IsDeleted { get; set; }
        public bool bit_AdHocAllowed { get; set; }
        public bool bit_ShowInSummary { get; set; }
        public string nvar_ExportKey { get; set; }
        public bool bit_CanSubmitBeforeScheduledDate { get; set; }
        public bool bit_RequiresAcknowledgment { get; set; }
        public bool bit_ShowCommentsInSummary { get; set; }
        public Nullable<System.DateTime> dt_SubmitStartDate { get; set; }
        public bool bit_IsSlo { get; set; }
        public bool bit_AllowComments { get; set; }
        public bool bit_NotifyUserScheduling { get; set; }
        public bool bit_ShowSubmissionHistory { get; set; }
        public bool bit_DisallowAdminAccess { get; set; }
        public bool bit_AllowFinalizationBeforeSubmission { get; set; }
        public Nullable<System.DateTime> dt_DueDate { get; set; }
        public bool bit_DisableEvidenceCollectionTool { get; set; }
    
        public virtual tbl_Districts tbl_Districts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_OASYSComponentForms> tbl_OASYSComponentForms { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_OASYSComponentTemplateForms> tbl_OASYSComponentTemplateForms { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_OASYSCriteriaStandardScores> tbl_OASYSCriteriaStandardScores { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_OASYSEvidenceCriteria> tbl_OASYSEvidenceCriteria { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_OASYSUserFormComments> tbl_OASYSUserFormComments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_OASYSRubricCrtieriaScores> tbl_OASYSRubricCrtieriaScores { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_OASYSSectionScores> tbl_OASYSSectionScores { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_OASYSSlos> tbl_OASYSSlos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_OASYSUnalignedEvidences> tbl_OASYSUnalignedEvidences { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_OASYSUserFormEvents> tbl_OASYSUserFormEvents { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_OASYSUserForms> tbl_OASYSUserForms { get; set; }
    }
}