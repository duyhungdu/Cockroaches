using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cockroaches.Core.Messages;
using Cockroaches.Model;
using Cockroaches.Repository.Queries;

namespace Cockroaches.ApplicationService.Implementation.Contract
{
    public interface IShareService : IService
    {
        #region LoginHistory
        BaseResponse<LoginHistory> AddLoginHistory(LoginHistory model);
        BaseListResponse<SPGetLoginHistory_Result> FilterLoginHistory(LoginHistoryQuery query);
        #endregion LoginHistory

        #region Statuses
        BaseListResponse<SPGetStatus_Result> FilterStatuses(StatusQuery query);
        #endregion Statuses
    }
}
