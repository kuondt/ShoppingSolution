using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSolution.ViewModels.Catalog.System.Users
{
    public class LoginRequestValidator : AbstractValidator<LoginRequest>
    {
        public LoginRequestValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("User name is requried");

            RuleFor(x => x.Passwrod).NotEmpty().WithMessage("Password is required")
                .MinimumLength(6).WithMessage("Password is at least 6 character");
        }
    }
}
