using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSolution.ViewModels.Common
{
    public class PagedResult<T> : PagedResultBase
    {
        public List<T> Items { get; set; }

    }
}
