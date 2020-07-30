using ShoppingSolution.Application.Dtos;
using ShoppingSolution.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSolution.Application.Catalog.Products.Dtos.Manage
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }

        public List<int> CategoyIds { get; set; }
    }
}
