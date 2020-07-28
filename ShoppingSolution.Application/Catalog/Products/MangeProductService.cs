using ShoppingSolution.Application.Catalog.Products.Dtos;
using ShoppingSolution.Application.Dtos;
using ShoppingSolution.Data.EF;
using ShoppingSolution.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSolution.Application.Catalog.Products
{
    public class MangeProductService : IManageProductService
    {
        private readonly ShoppingDBContext _context;
        public MangeProductService(ShoppingDBContext context)
        {
            _context = context;
        }
        public async Task<int> Create(ProductCreateRequest request)
        {
            var product = new Product()
            {
                Price = request.Price,
            };
            _context.Products.Add(product);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(int productId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ProductViewModel>>  GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<PagedViewModel<ProductViewModel>> GetAllPaging(string keyword, int pageIndex, int Pagesize)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(ProductEditRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
