using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cockroaches.Core.Queries;
using Cockroaches.Model;

namespace Cockroaches.Repository.Queries
{
    public class ProductQuery : BaseQuery<Product>
    {
        public int Id { get; set; }
        public string ProductCategoryIds { get; set; }
        public string Keyword { get; set; }
        public int CountItem { get; set; }
        public bool Logical { get; set; }
        public string UserId { get; set; }

    }
}

