//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cockroaches.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class SystemConfig
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }
        public int Type { get; set; }
        public bool AllowClientEdit { get; set; }
        public bool SystemConfig1 { get; set; }
        public bool Active { get; set; }
        public bool Deleted { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime EditedOn { get; set; }
        public string EditedBy { get; set; }
    }
}
