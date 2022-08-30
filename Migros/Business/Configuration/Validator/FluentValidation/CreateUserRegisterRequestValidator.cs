using DTO.Payment;
using DTO.User;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Configuration.Validator.FluentValidation
{
   public class CreateUserRegisterRequestValidator : AbstractValidator<CreateUserRequest>
    {
        public CreateUserRegisterRequestValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name cannot be empty");
            RuleFor(x => x.Email).NotEmpty();
            RuleFor(x => x.Telephone).NotEmpty().WithMessage("Telephone cannot be empty");
        }

        internal object Validate(CreateUserRegisterRequest register)
        {
            throw new NotImplementedException();
        }
    }
}
