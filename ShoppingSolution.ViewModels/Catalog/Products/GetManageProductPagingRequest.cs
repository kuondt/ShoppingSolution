﻿using ShoppingSolution.ViewModels.Common;
using System.Collections.Generic;

namespace ShoppingSolution.ViewModels.Catalog.Products
{
    public class GetManageProductPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }

        public List<int> CategoryIds { get; set; }
    }
}
