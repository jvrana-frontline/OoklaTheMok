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
    
    public partial class tbl_OASYSDistrictSettings
    {
        public int int_DistrictID { get; set; }
        public bool bit_RequireEvalAcknowledgment { get; set; }
        public bool bit_FinalizationRequiresApproval { get; set; }
        public bool bit_TypeChangeRequiresApproval { get; set; }
        public Nullable<int> int_EvalApprover { get; set; }
        public string nvar_FinalEvalReportName { get; set; }
        public bool bit_AllowTeacherArtifacts { get; set; }
        public bool bit_RequireEvalSummary { get; set; }
        public bool bit_RequireRolloverToFinalize { get; set; }
        public bool bit_RequireArtifactType { get; set; }
        public bool bit_RequireArtifactCategory { get; set; }
        public bool bit_RequireRubricAlignment { get; set; }
        public bool bit_RequireEvidenceTool { get; set; }
        public int int_EmailAlerts { get; set; }
        public bool bit_DisableAutomaticCoding { get; set; }
        public bool bit_ClearEvidenceAfterSync { get; set; }
        public bool bit_UseRightsVersusAssignments { get; set; }
        public bool bit_EnableEvidenceToolBackgroundForm { get; set; }
        public bool bit_AllowArtifactStatement { get; set; }
    
        public virtual tbl_Districts tbl_Districts { get; set; }
        public virtual tbl_UserProfile tbl_UserProfile { get; set; }
    }
}
