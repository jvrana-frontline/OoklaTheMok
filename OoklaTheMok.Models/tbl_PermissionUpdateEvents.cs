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
    
    public partial class tbl_PermissionUpdateEvents
    {
        public long Id { get; set; }
        public int UserID { get; set; }
        public string Action { get; set; }
        public System.DateTime EventTime { get; set; }
        public Nullable<System.DateTime> SentToPermissionService { get; set; }
        public Nullable<int> DistrictId { get; set; }
        public Nullable<int> PreviousDistrictId { get; set; }
    
        public virtual tbl_PermissionUpdateEventsQueue tbl_PermissionUpdateEventsQueue { get; set; }
    }
}
