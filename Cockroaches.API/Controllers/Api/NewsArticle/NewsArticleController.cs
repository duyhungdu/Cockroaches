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
    public class NewsArticleController : ApiController
    {
        private INewsArticleService newsService;

        /// <summary>
        /// Contructor
        /// </summary>
        /// <param name="_newsService"></param>
        public NewsArticleController(INewsArticleService _newsService)
        {
            newsService = _newsService;
        }
    }
}