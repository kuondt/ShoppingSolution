using ShoppingSolution.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSolution.ViewModels.Catalog.Products
{
    public class GetPublicProductPagingRequest : PagingRequestBase
    {
        public string languageId { get; set; }

        public int? CategoryId { get; set; }
    }
}
