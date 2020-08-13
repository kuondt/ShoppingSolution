﻿using ShoppingSolution.ViewModels.Catalog.System.Roles;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSolution.Application.System.Roles
{
    public interface IRoleService
    {
        Task<List<RoleViewModel>> GetAll();
    }
}
