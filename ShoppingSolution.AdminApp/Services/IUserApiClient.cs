using ShoppingSolution.ViewModels.Catalog.System.Users;
using ShoppingSolution.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSolution.ViewModels.Services
{
    public interface IUserApiClient
    {
        Task<string> Authenticate(LoginRequest request);

        Task<PagedResult<UserViewModel>> GetUsersPaging(GetUserPagingRequest request);

        Task<bool> RegisterUser(RegisterRequest registerRequest);
    }

}
