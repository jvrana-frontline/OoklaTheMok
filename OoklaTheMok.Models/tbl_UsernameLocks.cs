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
    
    public partial class tbl_UsernameLocks
    {
        public long int_UsernameLockId { get; set; }
        public string var_Username { get; set; }
        public System.DateTime dt_LockSetDTime { get; set; }
        public int int_LockDuration { get; set; }
    }
}