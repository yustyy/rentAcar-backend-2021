using Business.Constants;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.DailyPrice).GreaterThan(0).WithMessage(Messages.CarDailyPriceInvalid);
            RuleFor(c => c.Description).MinimumLength(2).WithMessage(Messages.CarDescriptionInvalid);

            RuleFor(c => c.BrandId).NotEmpty().WithMessage(Messages.CarBrandIdInvalid);
            RuleFor(c => c.ColorId).NotEmpty().WithMessage(Messages.CarColorIdInvalid);
            RuleFor(c => c.DailyPrice).NotEmpty().WithMessage(Messages.CarDailyPriceInvalid);
            RuleFor(c => c.Description).NotEmpty().WithMessage(Messages.CarDescriptionInvalid);
            RuleFor(c => c.ModelYear).NotEmpty().WithMessage(Messages.CarModelYearInvalid);
        }
    }
}
