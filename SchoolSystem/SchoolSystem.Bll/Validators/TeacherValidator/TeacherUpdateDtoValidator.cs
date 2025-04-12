using FluentValidation;
using SchoolSystem.Bll.Dtos;

namespace SchoolSystem.Bll.Validators.TeacherValidator;

public class TeacherUpdateDtoValidator : AbstractValidator<TeacherUpdateDto>
{
    public TeacherUpdateDtoValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage("Id is required.")
            .GreaterThan(0)
            .WithMessage("Id must be greater than 0.");
        RuleFor(x => x.FirstName)
            .NotEmpty()
            .WithMessage("First name is required.")
            .Length(2, 50)
            .WithMessage("First name must be between 2 and 50 characters.");
        RuleFor(x => x.LastName)
            .NotEmpty()
            .WithMessage("Last name is required.")
            .Length(2, 50)
            .WithMessage("Last name must be between 2 and 50 characters.");
        RuleFor(x => x.Age)
            .InclusiveBetween(18, 65)
            .WithMessage("Age must be between 18 and 65.");
        RuleFor(x => x.PhoneNumber)
            .Matches(@"^\+?[0-9]{10,15}$")
            .WithMessage("Phone number must be a valid format.");
        RuleFor(x => x.Grade)
            .NotEmpty()
            .WithMessage("Grade is required.");
        RuleFor(x => x.Subject)
            .NotEmpty()
            .WithMessage("Subject is required.");
    }
}
