using FluentValidation;

namespace Core.Application.Features.Concepts.Commands.CreateConceptCommand
{
    public class CreateConceptCommandValidator : AbstractValidator<CreateConceptCommand>
    {
        public CreateConceptCommandValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("{PropertyName} no debe ser vacio.")
                .MaximumLength(20).WithMessage("{PropertyName} no exceder de {MaxLength} caracteres.");

            RuleFor(p => p.Category)
                .NotEmpty().WithMessage("{PropertyName} no debe ser vacio.");
        }
    }
}
