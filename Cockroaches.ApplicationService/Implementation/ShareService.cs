using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Cockroaches.ApplicationService.Implementation.Contract;
using Cockroaches.Core.Messages;
using Cockroaches.Model;
using Cockroaches.Model.Validators;
using Cockroaches.Repository;
using Cockroaches.Repository.Queries;

namespace Cockroaches.ApplicationService
{

    public partial class ShareService : BaseService, IShareService
    {
        protected readonly LoginHistoryRepository _loginHistoryRepository;
        protected readonly ApplicationLoggingRepository _applicationLoggingRepository;
        protected readonly ItemImagesRepository _itemImagesRepository;
        protected readonly SystemConfigRepository _systemConfigRepositorty;
        protected readonly SocialNetworkConfigRepository _socialNetworkConfigRepository;
        protected readonly StatusRepository _statusRepository;
        public ShareService()
        {
            _loginHistoryRepository = new LoginHistoryRepository();
            _applicationLoggingRepository = new ApplicationLoggingRepository();
            _itemImagesRepository = new ItemImagesRepository();
            _systemConfigRepositorty = new SystemConfigRepository();
            _socialNetworkConfigRepository = new SocialNetworkConfigRepository();
            _statusRepository = new StatusRepository();
        }

        #region LoginHistory
        public BaseResponse<LoginHistory> AddLoginHistory(LoginHistory model)
        {
            var response = new BaseResponse<LoginHistory>();
            var errors = Validate<LoginHistory>(model, new LoginHistoryValidator());
            if (errors.Count() > 0)
            {
                BaseResponse<LoginHistory> errResponse = new BaseResponse<LoginHistory>(model, errors);
                errResponse.IsSuccess = false;
                return errResponse;
            }
            try
            {
                response.Value = _loginHistoryRepository.AddLoginHistory(model);
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Error: " + ex.Message + " StackTrace: " + ex.StackTrace;
            }
            return response;
        }
        public BaseListResponse<SPGetLoginHistory_Result> FilterLoginHistory(LoginHistoryQuery query)
        {
            var response = new BaseListResponse<SPGetLoginHistory_Result>();
            int count = 0;
            try
            {
                response.Data = _loginHistoryRepository.Filter(query, out count);
                response.TotalItems = count;
                response.PageNumber = query.PageNumber != 0 ? query.PageNumber : 1;
                response.PageSize = query.PageSize;
            }
            catch (Exception ex)
            {
                response.Message = "Error: " + ex.Message + " StackTrace: " + ex.StackTrace;
            }
            return response;
        }
        #endregion LoginHistory

        #region Statuses
        public BaseListResponse<SPGetStatus_Result> FilterStatuses(StatusQuery query)
        {
            var response = new BaseListResponse<SPGetStatus_Result>();
            int count = 0;
            try
            {
                response.Data = _statusRepository.Filter(query, out count);
                response.TotalItems = count;
                response.PageNumber = query.PageNumber != 0 ? query.PageNumber : 1;
                response.PageSize = query.PageSize;
            }
            catch (Exception ex)
            {
                response.Message = "Error: " + ex.Message + " StackTrace: " + ex.StackTrace;
                response.IsSuccess = false;
            }
            return response;
        }
        #endregion Statuses

    }
}
