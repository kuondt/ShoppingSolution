using ShoppingSolution.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSolution.ViewModels.Catalog.System.Users
{
    public class GetUserPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
    }
}
