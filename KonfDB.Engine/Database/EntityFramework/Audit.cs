//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KonfDB.Engine.Database.EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class Audit
    {
        public long AuditId { get; set; }
        public int AuditAreaId { get; set; }
        public string AuditIdentity { get; set; }
        public string Message { get; set; }
        public int UserId { get; set; }
        public System.DateTime ActionAtUtc { get; set; }
        public string Metadata1 { get; set; }
        public string Metadata2 { get; set; }
        public string Reason { get; set; }
    
        public virtual AuditArea AuditArea { get; set; }
    }
}
