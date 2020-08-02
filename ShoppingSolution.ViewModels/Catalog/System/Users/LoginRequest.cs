using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSolution.ViewModels.Catalog.System.Users
{
    public class LoginRequest
    {
        public string UserName { get; set; }

        public string Passwrod { get; set; }

        public bool RememberMe { get; set; }
    }
}
