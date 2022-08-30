using DTO.Payment;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Configuration.Validator.FluentValidation
{
    public class UpdatePaymentRequestValidator : AbstractValidator<UpdatePaymentRequest>
    {
        public UpdatePaymentRequestValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0);
            RuleFor(x => x.Staff_Name).NotEmpty().WithMessage("Staff name cannot be empty");
            RuleFor(x => x.Payment_Type).NotEmpty();
            RuleFor(x => x.Amount).NotEmpty().WithMessage("Amount cannot be empty");
        }

    }
}
