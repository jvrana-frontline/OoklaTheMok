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
    
    public partial class tbl_ContentStandards
    {
        public int int_ContentStandardID { get; set; }
        public int int_ContentID { get; set; }
        public int int_StandardID { get; set; }
    
        public virtual tbl_Content tbl_Content { get; set; }
    }
}