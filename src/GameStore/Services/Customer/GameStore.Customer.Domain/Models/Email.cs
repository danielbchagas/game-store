using FluentValidation;
using FluentValidation.Results;

namespace GameStore.Customer.Domain.Models
{
    public class Email : Entity
    {
        public string Address { get; set; }

        public Guid PersonID { get; set; }
        public virtual Person Person { get; set; }

        public ValidationResult Validate()
        {
            return new EmailValidator().Validate(this);
        }
    }

    public class EmailValidator : AbstractValidator<Email>
    {
        public EmailValidator()
        {
            RuleFor(e => e.Address)
                .MinimumLength(10)
                .MaximumLength(50)
                .NotEmpty();
            RuleFor(e => e.PersonID)
                .NotEmpty();
            RuleFor(e => e.Person)
                .NotNull();
        }
    }
}
