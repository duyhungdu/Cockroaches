using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cockroaches.Repository.Queries;
using Cockroaches.Model;
using Cockroaches.Repository.Infrastructure;
using System.Data.Entity.Core.Objects;

namespace Cockroaches.Repository
{
    public class StatusRepository : BaseRepository<Status>
    {
        public List<SPGetStatus_Result> Filter(StatusQuery query, out int count)
        {
            count = 0;
            int pageNumber = query.PageNumber != 0 ? query.PageNumber : 1;
            var start = 0;
            var limit = query.PageSize;
            start = (pageNumber - 1) * limit;
            int totalRow = 0;
            List<SPGetStatus_Result> result = new List<SPGetStatus_Result>();
            ObjectParameter prTotalRow = new ObjectParameter("total", totalRow);
            result = _entities.SPGetStatus(query.Type != null ? query.Type : "", query.Keyword != null ? query.Keyword : "", start, limit, prTotalRow).ToList();
            count = (prTotalRow.Value == null) ? 0 : Convert.ToInt32(prTotalRow.Value);
            return result;
        }
    }
}
