using FluentValidation;

namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.Employee.Validators
{
    public class EmployeeValidator : AbstractValidator<Employee.Entities.Employee>
    {
        public EmployeeValidator()
        {
            RuleSet("new", () =>
            {
                RuleFor(e => e.FirstName).NotEmpty().WithMessage("{PropertyName} cannot be empty");
            });
        }
    }
}
