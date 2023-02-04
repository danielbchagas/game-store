using FluentValidation;
using FluentValidation.Results;

namespace GameStore.Customer.Domain.Models
{
    public class Phone : Entity
    {
        public string Number { get; set; }

        public Guid PersonID { get; set; }
        public virtual Person Person { get; set; }

        public ValidationResult Validate()
        {
            return new PhoneValidator().Validate(this);
        }
    }

    public class PhoneValidator : AbstractValidator<Phone>
    {
        public PhoneValidator()
        {
            RuleFor(p => p.Number)
                .MinimumLength(11)
                .MaximumLength(14)
                .NotEmpty();
            RuleFor(p => p.PersonID)
                .NotEmpty();
            RuleFor(p => p.Person)
                .NotNull();
        }
    }
}
