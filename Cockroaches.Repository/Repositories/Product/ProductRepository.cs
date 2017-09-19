using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cockroaches.Repository.Infrastructure;
using Newtonsoft.Json;
using System.Web;
using System.Net;
using System.Globalization;
using System.Data.Entity.Core.Objects;
using Cockroaches.Model;
using Cockroaches.Repository.Queries;

namespace Cockroaches.Repository
{
    public partial class ProductRepository : BaseRepository<Product>
    {
        public List<SPGetProducts_Result> GetProducts(ProductQuery query)
        {
            return _entities.SPGetProducts(query.ProductCategoryIds != null ? query.ProductCategoryIds : "", query.Keyword != null ? query.Keyword : "", query.CountItem).ToList();
        }
    }
}
