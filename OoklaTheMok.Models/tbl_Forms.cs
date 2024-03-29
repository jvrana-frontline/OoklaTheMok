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
    
    public partial class tbl_Forms
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Forms()
        {
            this.tbl_Activities = new HashSet<tbl_Activities>();
            this.tbl_FormElements = new HashSet<tbl_FormElements>();
            this.tbl_FormRules = new HashSet<tbl_FormRules>();
            this.tbl_FormTemplates = new HashSet<tbl_FormTemplates>();
            this.tbl_LearningPlan = new HashSet<tbl_LearningPlan>();
        }
    
        public int int_FormID { get; set; }
        public int int_DistrictID { get; set; }
        public string var_FormName { get; set; }
        public string var_FormDesc { get; set; }
        public string var_TableName { get; set; }
        public string var_TextColor { get; set; }
        public string var_BGColor { get; set; }
        public int int_Border { get; set; }
        public string var_RequiredBGColor { get; set; }
        public string var_RequiredTextColor { get; set; }
        public string var_RedirectPage { get; set; }
        public bool bit_UseRights { get; set; }
        public bool bit_AdminOnly { get; set; }
        public string var_Type { get; set; }
        public string var_Mode { get; set; }
        public bool bit_ViewOnLeftNav { get; set; }
        public int int_Order { get; set; }
        public bool bit_UseForRegProvider { get; set; }
        public System.DateTime dt_StartDate { get; set; }
        public System.DateTime dt_EndDate { get; set; }
        public bool bit_Anonymous { get; set; }
        public bool bit_CanResubmit { get; set; }
        public bool bit_CanViewFullResults { get; set; }
        public bool bit_CanViewAnonResults { get; set; }
        public bool bit_Archived { get; set; }
        public int int_SurveyID { get; set; }
        public bool bit_Deleted { get; set; }
        public int int_Questions { get; set; }
        public bool bit_IsActivityProposal { get; set; }
        public bool bit_ProposalAllStaff { get; set; }
        public bool bit_ProposalInstructors { get; set; }
        public bool bit_ProposalAdmins { get; set; }
        public bool bit_AllowRevisions { get; set; }
        public bool bit_IsMarkCompleteForm { get; set; }
        public bool bit_IsUserProfileForm { get; set; }
        public int int_ProgramID { get; set; }
        public bool bit_IsConfForm { get; set; }
        public bool bit_IsConfSessionForm { get; set; }
        public bool bit_CanViewAnonGroupings { get; set; }
        public bool bit_IsValid { get; set; }
        public bool bit_IsCatalogForm { get; set; }
        public bool bit_IsRegForm { get; set; }
        public bool bit_IsUserInfoForm { get; set; }
        public int int_MarkCompleteFormID { get; set; }
        public bool bit_Share { get; set; }
        public int int_AdminID { get; set; }
        public string var_StyleClass { get; set; }
        public bool bit_IsPDPForm { get; set; }
        public bool bit_EmailApproverOnDrop { get; set; }
        public bool bit_EmailAssistantOnDrop { get; set; }
        public bool bit_IsResumeForm { get; set; }
        public bool bit_IsTeamRoomForm { get; set; }
        public string var_Instructions { get; set; }
        public Nullable<bool> bit_DWExport { get; set; }
        public string Discriminator { get; set; }
        public bool bit_AllowDropOnDenial { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Activities> tbl_Activities { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_FormElements> tbl_FormElements { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_FormRules> tbl_FormRules { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_FormTemplates> tbl_FormTemplates { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_LearningPlan> tbl_LearningPlan { get; set; }
    }
}
