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
    
    public partial class tbl_PermissionUpdateEventsQueue
    {
        public long EventId { get; set; }
        public int UserId { get; set; }
    
        public virtual tbl_PermissionUpdateEvents tbl_PermissionUpdateEvents { get; set; }
    }
}
