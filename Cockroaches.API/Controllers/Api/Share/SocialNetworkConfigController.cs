using System.Web.Http;
using Cockroaches.Model;
using Cockroaches.Core.Messages;
using Cockroaches.ApplicationService.Implementation.Contract;

namespace Cockroaches.API.Controllers.Api.Share
{
    /// <summary>
    /// Social Network Config API
    /// </summary>
    public class SocialNetworkConfigController : ApiController
    {
        private IShareService shareService;
        /// <summary>
        /// Contructor
        /// </summary>
        /// <param name="_shareService"></param>
        public SocialNetworkConfigController(IShareService _shareService)
        {
            shareService = _shareService;
        }
    }
}
