using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Cockroaches.ApplicationService.Implementation.Contract;
using Cockroaches.Core.Messages;
using Cockroaches.Model;
using Cockroaches.Repository;

namespace Cockroaches.API.Controllers.Api
{
    /// <summary>
    /// Banner API
    /// </summary>
    public class MediaController : ApiController
    {
        IMediaService mediaService;
        /// <summary>
        /// Contructor
        /// </summary>
        /// <param name="_mediaService"></param>
        public MediaController(IMediaService _mediaService)
        {
            mediaService = _mediaService;
        }
        
    }
}