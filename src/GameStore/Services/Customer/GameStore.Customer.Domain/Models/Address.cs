using FluentValidation;
using FluentValidation.Results;

namespace GameStore.Customer.Domain.Models
{
    public class Address : Entity
    {
        public string FirstLine { get; set; }
        public string SecondLine { get; set; }
        public string ZipCode { get; set; }

        public Guid PersonID { get; set; }
        public virtual Person Person { get; set; }

        public ValidationResult Validate()
        {
            return new AddressValidator().Validate(this);
        }
    }

    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(p => p.FirstLine)
                .MinimumLength(10)
                .MaximumLength(30)
                .NotEmpty();
            RuleFor(p => p.SecondLine)
                .MinimumLength(10)
                .MaximumLength(30)
                .NotEmpty();
            RuleFor(p => p.ZipCode)
                .MinimumLength(5)
                .MaximumLength(10)
                .NotEmpty();
            RuleFor(p => p.PersonID)
                .NotEmpty();
            RuleFor(p => p.Person)
                .NotNull();
        }
    }
}
