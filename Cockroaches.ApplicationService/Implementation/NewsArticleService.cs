using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cockroaches.ApplicationService.Implementation.Contract;
using Cockroaches.Core.Messages;
using Cockroaches.Model;
using Cockroaches.Model.Validators;
using Cockroaches.Repository;
using Cockroaches.Repository.Queries;
using Cockroaches.Model.CustomEntities;

namespace Cockroaches.ApplicationService
{
    public partial class NewsArticleService : BaseService, INewsArticleService
    {
        protected readonly NewsArticleRepository _newsArticleRepository;
        protected readonly NewsCategoryNewsarticlesRepository _newsCategoryNewsarticlesRepository;
        protected readonly NewsCategoryRepository _newsCategoryRepository;

        public NewsArticleService()
        {
            _newsArticleRepository = new NewsArticleRepository();
            _newsCategoryRepository = new NewsCategoryRepository();
            _newsCategoryNewsarticlesRepository = new NewsCategoryNewsarticlesRepository();
        }

     
    }

}
