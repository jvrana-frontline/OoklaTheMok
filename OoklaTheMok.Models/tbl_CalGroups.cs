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
    
    public partial class tbl_CalGroups
    {
        public int int_CalGroupID { get; set; }
        public int int_CalendarID { get; set; }
        public int int_GroupID { get; set; }
    
        public virtual tbl_Calendars tbl_Calendars { get; set; }
        public virtual tbl_Groups tbl_Groups { get; set; }
    }
}