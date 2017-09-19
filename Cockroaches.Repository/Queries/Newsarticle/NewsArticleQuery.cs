using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cockroaches.Core.Queries;
using Cockroaches.Model;

namespace Cockroaches.Repository.Queries
{
    public class NewsArticleQuery : BaseQuery<NewsArticle>
    {
        public int Id { get; set; }
        public int Status { get; set; }
        public string Keyword { get; set; }
        public string NewsCategoryIds { get; set; }
        public int CountItem { get; set; }
        public bool Logical { get; set; }
        public string UserId { get; set; }
    }
}

