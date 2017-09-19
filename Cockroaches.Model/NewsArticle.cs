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
    
    public partial class NewsArticle
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string NewsContent { get; set; }
        public bool TopNewsArticle { get; set; }
        public int CountView { get; set; }
        public string Author { get; set; }
        public string MetaTitle { get; set; }
        public string MetaTags { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeyword { get; set; }
        public int StatusId { get; set; }
        public bool Published { get; set; }
        public Nullable<System.DateTime> PublishedOn { get; set; }
        public string PublishedBy { get; set; }
        public bool Deleted { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime EditedOn { get; set; }
        public string EditedBy { get; set; }
    }
}
