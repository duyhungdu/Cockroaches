using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cockroaches.Core.Messages;
using Cockroaches.Model;
using Cockroaches.Repository.Queries;
using Cockroaches.Model.CustomEntities;

namespace Cockroaches.ApplicationService.Implementation.Contract
{
    public interface IProductService : IService
    {
        #region BackEnd
        #region ProductCategories
        BaseListResponse<SPGetProductCategoriesByParentId_Result> GetProductCategoriesByParentId(int parentId);
        BaseListResponse<ProductCategoriesTree> GetProductCategoriesTree(int parentId);
        #endregion ProductCategories

        #region Product
        BaseListResponse<SPGetProducts_Result> GetProducts(ProductQuery query);
        BaseResponse<Product> DeleteProduct(ProductQuery query);
        #endregion Product
        #endregion BackEnd

        #region FrontEnd

        #endregion FrontEnd
    }
}
