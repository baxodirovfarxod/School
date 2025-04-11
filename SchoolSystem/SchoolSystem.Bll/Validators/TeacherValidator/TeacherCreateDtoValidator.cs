using FluentValidation;
using SchoolSystem.Bll.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Bll.Validators.TeacherValidator;

public class TeacherCreateDtoValidator : AbstractValidator<TeacherCreateDto>
{
    public TeacherCreateDtoValidator()
    {
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
