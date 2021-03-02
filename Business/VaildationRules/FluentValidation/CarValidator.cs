using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.VaildationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(p => p.CarName).MinimumLength(2);
            RuleFor(p => p.CarName).NotEmpty();
            RuleFor(p => p.DailyPrice).GreaterThan(0); 
        }
    }
}
