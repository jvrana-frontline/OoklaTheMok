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
    
    public partial class tbl_RegTransactionTypes
    {
        public int int_RegTransactionTypeID { get; set; }
        public int int_DistrictID { get; set; }
        public string var_Description { get; set; }
        public bool bit_IsDebit { get; set; }
        public float rl_Percentage { get; set; }
        public int int_CancelDays { get; set; }
    
        public virtual tbl_Districts tbl_Districts { get; set; }
    }
}
