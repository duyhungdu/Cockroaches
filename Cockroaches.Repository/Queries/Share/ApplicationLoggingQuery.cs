using Cockroaches.Core.Queries;
using Cockroaches.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cockroaches.Repository.Queries
{
    public class StatusQuery : BaseQuery<Status>
    {
        public string Type { get; set; }
        public string Keyword { get; set; }
    }
}
