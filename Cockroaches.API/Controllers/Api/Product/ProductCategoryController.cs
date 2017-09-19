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
    public class ProductCategoryController : ApiController
    {
        IProductService productService;
        /// <summary>
        /// Contructor
        /// </summary>
        /// <param name="_productService"></param>
        public ProductCategoryController(IProductService _productService)
        {
            productService = _productService;
        }

        /// <summary>
        /// Get all ProductCategories by ParentId
        /// </summary>
        /// <param name="parentId"></param>
        /// <returns></returns>
        [HttpGet]
        public BaseListResponse<SPGetProductCategoriesByParentId_Result> GetProductCategoriesByParentId(int parentId)
        {
            return productService.GetProductCategoriesByParentId(parentId);
        }
        /// <summary>
        /// Build a ProductCategories Tree
        /// </summary>
        /// <param name="parentId"></param>
        /// <returns></returns>
        [HttpGet]
        public BaseListResponse<ProductCategoriesTree> GetProductCategoriesTree(int parentId)
        {
            return productService.GetProductCategoriesTree(parentId);
        }
    }
}