using Business.Constants;
using Core.Entities.Concrete;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.Email).NotEmpty().WithMessage(Messages.UserEmailInvalid);
            RuleFor(u => u.FirstName).NotEmpty().WithMessage(Messages.UserFirstNameInvalid);
            RuleFor(u => u.LastName).NotEmpty().WithMessage(Messages.UserLastNameInvalid);
            RuleFor(u => u.PasswordHash).NotEmpty().WithMessage(Messages.UserPasswordInvalid);
        }
    }
}
