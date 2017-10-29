using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Cockroaches.ApplicationService.Implementation.Contract;
using Cockroaches.Core.Messages;
using Cockroaches.Model;
using Cockroaches.Repository.Queries;

namespace Cockroaches.API.Controllers.Api
{
    /// <summary>
    /// Share API
    /// </summary>
    public class StatusController : ApiController
    {
        private IShareService shareService;

        /// <summary>
        /// Contructor
        /// </summary>
        /// <param name="_shareService"></param>
        public StatusController(IShareService _shareService)
        {
            shareService = _shareService;
        }
        /// <summary>
        /// Filter Statuses
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        [HttpGet]
        public BaseListResponse<SPGetStatus_Result> Search([FromUri]StatusQuery query)
        {
            return shareService.FilterStatuses(query);
        }
    }
}