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
using System.Web;

namespace Cockroaches.ApplicationService.Implementation
{

    public partial class ProductService : BaseService, IProductService
    {
        ProductCategoryRepository _productCategoryRepository;
        ProductRepository _productRepository;
        ApplicationLoggingRepository _applicationLoggingRepository;
        public ProductService()
        {
            _productCategoryRepository = new ProductCategoryRepository();
            _productRepository = new ProductRepository();
            _applicationLoggingRepository = new ApplicationLoggingRepository();
        }

        #region BackEnd



        #region ProductCategories
        public BaseListResponse<SPGetProductCategoriesByParentId_Result> GetProductCategoriesByParentId(int parentId)
        {
            BaseListResponse<SPGetProductCategoriesByParentId_Result> response = new BaseListResponse<SPGetProductCategoriesByParentId_Result>();
            List<SPGetProductCategoriesByParentId_Result> subProductCategories = new List<SPGetProductCategoriesByParentId_Result>();
            subProductCategories = _productCategoryRepository.GetProductCategoriesByParentId(parentId);
            response.Data = subProductCategories;
            response.TotalItems = subProductCategories.Count;
            return response;
        }
        public BaseListResponse<ProductCategoriesTree> GetProductCategoriesTree(int parentId)
        {
            List<ProductCategoriesTree> responseData = new List<ProductCategoriesTree>();
            List<SPGetProductCategoriesByParentId_Result> productCategories = new List<SPGetProductCategoriesByParentId_Result>();
            productCategories = _productCategoryRepository.GetProductCategoriesByParentId(parentId);
            int order = 0;
            foreach (var item in productCategories)
            {
                ProductCategoriesTree node = new ProductCategoriesTree { Id = item.Id, Code = item.Code, Level = 1, Order = order, ParentId = parentId, Title = item.Title };
                responseData.Add(node);
                int subOrder = 0;
                foreach (var subItem in _productCategoryRepository.GetProductCategoriesByParentId(item.Id))
                {
                    ProductCategoriesTree subNode = new ProductCategoriesTree { Id = subItem.Id, Code = subItem.Code, Level = 2, Order = subOrder, ParentId = item.Id, Title = subItem.Title };
                    responseData.Add(subNode);
                    int sub3rdOrder = 0;
                    foreach (var sub3rdItem in _productCategoryRepository.GetProductCategoriesByParentId(subItem.Id))
                    {
                        ProductCategoriesTree sub3rdNode = new ProductCategoriesTree { Id = sub3rdItem.Id, Code = sub3rdItem.Code, Level = 3, Order = sub3rdOrder, ParentId = subItem.Id, Title = sub3rdItem.Title };
                        responseData.Add(sub3rdNode);
                        int sub4thOrder = 0;
                        foreach (var sub4thItem in _productCategoryRepository.GetProductCategoriesByParentId(sub3rdItem.Id))
                        {
                            ProductCategoriesTree sub4thNode = new ProductCategoriesTree { Id = sub4thItem.Id, Code = sub4thItem.Code, Level = 4, Order = sub4thOrder, ParentId = sub3rdItem.Id, Title = sub4thItem.Title };
                            responseData.Add(sub4thNode);
                            sub4thOrder++;
                        }
                        sub3rdOrder++;
                    }
                    subOrder++;
                }
            }
            order++;

            BaseListResponse<ProductCategoriesTree> response = new BaseListResponse<ProductCategoriesTree>();
            response.TotalItems = responseData.Count;
            response.Data = responseData;
            return response;
        }
        #endregion ProductCategories


        #region Product
        public BaseListResponse<SPGetProducts_Result> GetProducts(ProductQuery query)
        {
            BaseListResponse<SPGetProducts_Result> response = new BaseListResponse<SPGetProducts_Result>();
            List<SPGetProducts_Result> products = _productRepository.GetProducts(query);
            response.Data = products;
            response.TotalItems = products.Count;
            return response;
        }
        public BaseResponse<Product> DeleteProduct(ProductQuery query)
        {
            BaseResponse<Product> response = new BaseResponse<Product>();
            Product product = _productRepository.GetById(query.Id);
            if (query.Logical)
            {

                product.Deleted = true;
                product.EditedOn = DateTime.Now;
                product.EditedBy = query.UserId;
                _productRepository.Edit(product);
                response.Value = product;
                _applicationLoggingRepository.Log("EVENT", "DELETE", "Product", product.Id.ToString(), "", "", "", "", HttpContext.Current.Request.UserHostAddress, query.UserId);
            }
            else
            {
                _productRepository.Delete(product);

            }
            return response;
        }
        #endregion Product




        #endregion BackEnd






        #region FrontEnd

        #endregion FrontEnd
    }
}
