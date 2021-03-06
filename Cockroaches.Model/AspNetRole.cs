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
    
    public partial class AspNetRole
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AspNetRole()
        {
            this.AspNetUserRoles = new HashSet<AspNetUserRole>();
        }
    
        public string Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string GroupBy { get; set; }
        public int Order { get; set; }
        public string ParentId { get; set; }
        public Nullable<bool> Root { get; set; }
        public Nullable<bool> Leaf { get; set; }
        public string Href { get; set; }
        public string Target { get; set; }
        public string Icon { get; set; }
        public Nullable<bool> OnMainMenu { get; set; }
        public Nullable<bool> OnTopMenu { get; set; }
        public Nullable<bool> OnRightMenu { get; set; }
        public bool AllowClientAccess { get; set; }
        public bool HasChild { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<bool> Deleted { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> EditedOn { get; set; }
        public string EditedBy { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AspNetUserRole> AspNetUserRoles { get; set; }
    }
}
