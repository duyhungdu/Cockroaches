using Cockroaches.Core.Queries;
using Cockroaches.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cockroaches.Repository
{
    public class BannerQuery : BaseQuery<Banner>
    {
        public int Id { get; set; }
        public int Position { get; set; }
        public string Keyword { get; set; }
        public int SitePosition { get; set; }
        public int CountItem { get; set; }
        public bool Logical { get; set; }
        public int Type { get; set; }
        public string UserId { get; set; }
    }
}
