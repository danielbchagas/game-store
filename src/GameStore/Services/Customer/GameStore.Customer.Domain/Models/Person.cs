using FluentValidation;
using FluentValidation.Results;

namespace GameStore.Customer.Domain.Models
{
    public class Person : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Document Document { get; set; }
        public Phone Phone { get; set; }
        public Email Email { get; set; }
        public Address Address { get; set; }

        public ValidationResult Validate()
        {
            return new PersonValidator().Validate(this);
        }
    }

    public class PersonValidator : AbstractValidator<Person>
    {
        public PersonValidator()
        {
            RuleFor(p => p.FirstName)
                .MinimumLength(3)
                .MaximumLength(30)
                .NotEmpty();
            RuleFor(p => p.LastName)
                .MinimumLength(3)
                .MaximumLength(50)
                .NotEmpty();
            RuleFor(p => p.Email)
                .NotNull();
            RuleFor(p => p.Address)
                .NotNull();
            RuleFor(p => p.Phone)
                .NotNull();
            RuleFor(p => p.Document)
                .NotNull();
        }
    }
}
