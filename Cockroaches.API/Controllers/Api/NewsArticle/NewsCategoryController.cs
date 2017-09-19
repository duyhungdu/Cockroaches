using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Cockroaches.ApplicationService.Implementation.Contract;
using Cockroaches.Core.Messages;
using Cockroaches.Model;
using Cockroaches.Repository.Queries;
using Cockroaches.Model.CustomEntities;

namespace Cockroaches.API.Controllers.Api
{
    /// <summary>
    /// News API
    /// </summary>
    public class NewsCategoryController : ApiController
    {
        private INewsArticleService newsCategoryService;

        /// <summary>
        /// Contructor
        /// </summary>
        /// <param name="_newsCategoryService"></param>
        public NewsCategoryController(INewsArticleService _newsCategoryService)
        {
            newsCategoryService = _newsCategoryService;
        }
     
    }
}