using Cockroaches.Core.Queries;
using Cockroaches.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cockroaches.Repository.Queries
{
    public class ApplicationLoggingQuery : BaseQuery<ApplicationLogging>
    {
        public string Keyword { get; set; }
    }
}
