using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core.Objects;
using Cockroaches.Model;
using Cockroaches.Repository.Queries;
using Cockroaches.Repository.Infrastructure;
namespace Cockroaches.Repository
{
    public partial class ProductCategoryRepository : BaseRepository<ProductCategory>
    {
        public List<SPGetProductCategoriesByParentId_Result> GetProductCategoriesByParentId(int parentId)
        {
            return _entities.SPGetProductCategoriesByParentId(parentId).ToList();
        }
    }
}
