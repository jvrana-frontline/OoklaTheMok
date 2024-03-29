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
    
    public partial class tbl_Programs
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Programs()
        {
            this.tbl_RegPEnrollmentTypes = new HashSet<tbl_RegPEnrollmentTypes>();
            this.tbl_RegPPaymentTypes = new HashSet<tbl_RegPPaymentTypes>();
        }
    
        public int int_ProgramID { get; set; }
        public int int_DistrictID { get; set; }
        public string var_Name { get; set; }
        public bool bit_ApprovalRequired { get; set; }
        public bool bit_Membership { get; set; }
        public bool bit_SearchTerm { get; set; }
        public bool bit_SearchPrograms { get; set; }
        public bool bit_SearchStandards { get; set; }
        public bool bit_SearchInstructor { get; set; }
        public int int_SearchResultsFormatID { get; set; }
        public bool bit_ProfileShowInstructor { get; set; }
        public bool bit_ProfileShowProgram { get; set; }
        public bool bit_ProfileShowAudience { get; set; }
        public bool bit_ProfileShowStandards { get; set; }
        public bool bit_ProfileShowSubscriberFee { get; set; }
        public bool bit_ProfileShowSubscribers { get; set; }
        public bool bit_DistrictPermissionRequired { get; set; }
        public string var_Code { get; set; }
        public int int_Order { get; set; }
        public string var_EmailAddress { get; set; }
        public string var_EmailConf { get; set; }
        public string var_EmailCredit { get; set; }
        public string var_EmailWaitList { get; set; }
        public string var_EmailDeny { get; set; }
        public string var_PayTo { get; set; }
        public bool bit_RegAskPermission { get; set; }
        public bool bit_RegPositionTypeRequired { get; set; }
        public bool bit_RegBuildingRequired { get; set; }
        public bool bit_RegJobTitleRequired { get; set; }
        public bool bit_RegCertificateHolderRequired { get; set; }
        public bool bit_RegSSNRequired { get; set; }
        public bool bit_RegAddressRequired { get; set; }
        public bool bit_RegPhoneRequired { get; set; }
        public string var_Fax { get; set; }
        public string var_Phone { get; set; }
        public string var_Address1 { get; set; }
        public string var_Address2 { get; set; }
        public string var_City { get; set; }
        public string var_State { get; set; }
        public string var_Zip { get; set; }
        public bool bit_RosterShowHours { get; set; }
        public bool bit_RosterShowDistrict { get; set; }
        public bool bit_RosterShowBuilding { get; set; }
        public bool bit_RosterShowEmail { get; set; }
        public bool bit_RosterShowAddress { get; set; }
        public bool bit_RosterShowSub { get; set; }
        public bool bit_RosterShowStipend { get; set; }
        public bool bit_RosterShowIsSubscriber { get; set; }
        public bool bit_RosterShowIsMLP { get; set; }
        public bool bit_RosterShowPaymentMethod { get; set; }
        public bool bit_RosterShowPaymentStatus { get; set; }
        public bool bit_RosterShowEnrollmentOption { get; set; }
        public bool bit_RosterShowPhone { get; set; }
        public bool bit_SendEmailtoDistrict { get; set; }
        public string var_SignatureFileName { get; set; }
        public bool bit_RegWorkPhoneRequired { get; set; }
        public string var_SignaturePrintedName { get; set; }
        public string var_EmailCancelActivity { get; set; }
        public string var_EmailCompletedCourse { get; set; }
        public string var_MLPRegistrationInstructions { get; set; }
        public string var_NonMLPRegistrationInstructions { get; set; }
        public bool bit_EmailRegistrationInstructions { get; set; }
        public bool bit_ShowCategories { get; set; }
        public bool bit_SearchCategories { get; set; }
        public int int_CCGatewayProviderID { get; set; }
        public string var_CCGatewayUserID { get; set; }
        public string var_CCGatewayPassword { get; set; }
        public bool bit_CCGatewaySendUserEmail { get; set; }
        public bool bit_CCGatewaySendProgramEmail { get; set; }
        public bool bit_CCGatewayTestMode { get; set; }
        public bool bit_CCAutoRefund { get; set; }
        public bool bit_AutoRefundOnDrop { get; set; }
        public bool bit_AutoRefundOnCancel { get; set; }
        public bool bit_AutoRefundOnDelete { get; set; }
        public string chr_ProgramOptions { get; set; }
        public bool bit_CCPayOnRegistration { get; set; }
        public string var_WaitListInstructions { get; set; }
        public bool bit_AutoWaitList { get; set; }
        public bool bit_RosterShowJobTitle { get; set; }
        public bool bit_RosterShowPosition { get; set; }
        public bool bit_ShowEnrollmentForm { get; set; }
        public bool bit_RegPositionTypeIDRequired { get; set; }
        public bool bit_RegDateofBirthRequired { get; set; }
        public bool bit_RegCitizenshipRequired { get; set; }
        public bool bit_RegGenderRequired { get; set; }
        public bool bit_AllowDrops { get; set; }
        public bool bit_FlyerShowLogo { get; set; }
        public bool bit_FlyerShowProgramName { get; set; }
        public bool bit_FlyerShowProgramFooter { get; set; }
        public bool bit_FlyerShowMemberDistricts { get; set; }
        public string var_FlyerInstructions { get; set; }
        public string var_ProgramLogo { get; set; }
        public string var_HeaderColor { get; set; }
        public bool bit_RegWorkAddressRequired { get; set; }
        public bool bit_RegEmployeeIDRequired { get; set; }
        public bool bit_RegCollegeInfoRequired { get; set; }
        public bool bit_RegPBSUserNameRequired { get; set; }
        public string txt_EnrollmentTerms { get; set; }
        public bool bit_RegPhysicalAssistanceRequired { get; set; }
        public string var_AddressTo { get; set; }
        public bool bit_ShowCourseGrades { get; set; }
        public bool bit_ShowSessionAttendance { get; set; }
        public bool bit_Active { get; set; }
        public bool bit_RegCertificateIDRequired { get; set; }
        public bool bit_WebRegEnroll { get; set; }
        public int int_ActivityFormID { get; set; }
        public string var_ShortName { get; set; }
        public bool bit_AskUSCitizenship { get; set; }
        public bool bit_AskIsHispanic { get; set; }
        public bool bit_AskRaceType { get; set; }
        public bool bit_YearLongActivities { get; set; }
        public int int_ReOfferFormID { get; set; }
        public bool bit_RegStateEmployeeIDRequired { get; set; }
    
        public virtual tbl_Districts tbl_Districts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_RegPEnrollmentTypes> tbl_RegPEnrollmentTypes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_RegPPaymentTypes> tbl_RegPPaymentTypes { get; set; }
    }
}
