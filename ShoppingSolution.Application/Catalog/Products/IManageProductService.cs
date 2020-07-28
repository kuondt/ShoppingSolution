using ShoppingSolution.Application.Catalog.Products.Dtos;
using ShoppingSolution.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSolution.Application.Catalog.Products
{
    public interface IManageProductService
    {
        Task<int> Create(ProductCreateRequest request);

        Task<int> Update(ProductEditRequest request);

        Task<int> Delete(int productId);

        Task<List<ProductViewModel>> GetAll();

        Task<PagedViewModel<ProductViewModel>> GetAllPaging(String keyword, int pageIndex, int Pagesize);
    }
}
