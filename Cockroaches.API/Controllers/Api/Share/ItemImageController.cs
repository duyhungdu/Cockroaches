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
    /// News API
    /// </summary>
    public class ItemImageController : ApiController
    {
        private IShareService itemImageService;

        /// <summary>
        /// Contructor
        /// </summary>
        /// <param name="_itemImageService"></param>
        public ItemImageController(IShareService _itemImageService)
        {
            itemImageService = _itemImageService;
        }
    }
}