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
    
    public partial class tbl_OASYSTripodQuestions
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_OASYSTripodQuestions()
        {
            this.tbl_OASYSTripodAnswers = new HashSet<tbl_OASYSTripodAnswers>();
        }
    
        public int int_QuestionID { get; set; }
        public int int_CategoryID { get; set; }
        public int int_LevelID { get; set; }
        public System.DateTime dt_DateCreated { get; set; }
        public string nvar_Name { get; set; }
        public int int_Order { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_OASYSTripodAnswers> tbl_OASYSTripodAnswers { get; set; }
        public virtual tbl_OASYSTripodCategories tbl_OASYSTripodCategories { get; set; }
        public virtual tbl_OASYSTripodLevels tbl_OASYSTripodLevels { get; set; }
    }
}
