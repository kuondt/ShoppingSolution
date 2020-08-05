using Microsoft.AspNetCore.Mvc.RazorPages;
using ShoppingSolution.ViewModels.Catalog.System.Users;
using ShoppingSolution.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSolution.Application.System.Users
{
    public interface IUserService
    {
        Task<string> Authencate(LoginRequest request);

        Task<bool> Register(RegisterRequest request);

        Task<PagedResult<UserViewModel>> GetUserPaging(GetUserPagingRequest request);
    }
}
