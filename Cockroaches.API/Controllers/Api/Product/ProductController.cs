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
    [Authorize]
    public class ProductController : ApiController
    {
        IProductService productService;
        /// <summary>
        /// Contructor
        /// </summary>
        /// <param name="_productService"></param>
        public ProductController(IProductService _productService)
        {
            productService = _productService;
        }

        /// <summary>
        /// Get Products by ProductCategoryIds. User must have products roles to access
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        [Authorize(Roles = "products")]
        [HttpGet]
        public BaseListResponse<SPGetProducts_Result> GetProducts([FromUri] ProductQuery query)
        {
            return productService.GetProducts(query);
        }


        /// <summary>
        /// Mark a product as deleted or delete from database
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        [HttpPut]
        public BaseResponse<Product> Delete(ProductQuery query)
        {
            return productService.DeleteProduct(query);
        }

    }

}