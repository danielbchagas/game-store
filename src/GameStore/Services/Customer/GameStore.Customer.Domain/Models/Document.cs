using FluentValidation;
using FluentValidation.Results;

namespace GameStore.Customer.Domain.Models
{
    public class Document : Entity
    {
        public string Number { get; set; }

        public Guid PersonID { get; set; }
        public virtual Person Person { get; set; }

        public ValidationResult Validate()
        {
            return new DocumentValidator().Validate(this);
        }
    }

    public class DocumentValidator : AbstractValidator<Document>
    {
        public DocumentValidator()
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
