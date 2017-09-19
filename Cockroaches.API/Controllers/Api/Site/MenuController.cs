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
    /// Menu API
    /// </summary>
    public class MenuController : ApiController
    {
        private ISiteService siteService;

        /// <summary>
        /// Contructor
        /// </summary>
        /// <param name="_siteService"></param>
        public MenuController(ISiteService _siteService)
        {
            siteService = _siteService;
        }
    }
}