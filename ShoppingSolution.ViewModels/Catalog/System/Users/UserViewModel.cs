﻿using ShoppingSolution.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShoppingSolution.ViewModels.Catalog.System.Users
{
    public class UserViewModel
    {
        public Guid Id { get; set; }

        [Display(Name = "Tên")]
        public string FirstName { get; set; }

        [Display(Name = "Họ")]
        public string LastName { get; set; }

        [Display(Name = "SĐT")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Tài khoản")]
        public string UserName { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Ngày sinh")]
        public DateTime Dob { get; set; }

        public IList<string> Roles { get; set; }
    }
}
