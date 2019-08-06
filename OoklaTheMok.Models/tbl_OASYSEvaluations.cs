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
    
    public partial class tbl_OASYSEvaluations
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_OASYSEvaluations()
        {
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
    
        public int int_EvaluationID { get; set; }
        public Nullable<int> int_UserID { get; set; }
        public System.DateTime dt_StartDate { get; set; }
        public Nullable<System.DateTime> dt_EndDate { get; set; }
        public bool bit_IsAcknowledged { get; set; }
        public bool bit_IsCompleted { get; set; }
        public Nullable<System.DateTime> dt_CompletedDate { get; set; }
        public Nullable<int> int_CompletedBy { get; set; }
        public Nullable<int> int_EvalType { get; set; }
        public bool bit_AwaitingApproval { get; set; }
        public bool bit_IsActive { get; set; }
        public string var_FinalizedBuildingIDList { get; set; }
        public string var_FinalizedBuildingNameList { get; set; }
        public string var_FinalizedDepartmentIDList { get; set; }
        public string var_FinalizedDepartmentNameList { get; set; }
        public string var_FinalizedGradeIDList { get; set; }
        public string var_FinalizedGradeNameList { get; set; }
        public string var_FinalizedGroupIDList { get; set; }
        public string var_FinalizedGroupNameList { get; set; }
        public string var_FinalizedPositionTypeIDList { get; set; }
        public string var_FinalizedPositionTypeNameList { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_OASYSCriteriaStandardScores> tbl_OASYSCriteriaStandardScores { get; set; }
        public virtual tbl_OASYSEvaluationApprovals tbl_OASYSEvaluationApprovals { get; set; }
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