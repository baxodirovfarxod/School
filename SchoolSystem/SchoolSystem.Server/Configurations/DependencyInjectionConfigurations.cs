using FluentValidation;
using SchoolSystem.Bll.Dtos;
using SchoolSystem.Bll.Services.ClassRoomServices;
using SchoolSystem.Bll.Services.StudentServices;
using SchoolSystem.Bll.Services.TeacherServices;
using SchoolSystem.Bll.Validators.TeacherValidator;
using SchoolSystem.Repository.Services.ClassRoomRepository;
using SchoolSystem.Repository.Services.StudentRepository;
using SchoolSystem.Repository.Services.TeacherRepository;

namespace SchoolSystem.Server.Configurations;

public static class DependencyInjectionConfigurations
{
    public static void DIConfigure(this WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<ITeacherServices, TeacherServices>();
        builder.Services.AddScoped<IStudentServices, StudentServices>();
        builder.Services.AddScoped<IClassRoomServices, ClassRoomServices>();

        builder.Services.AddScoped<ITeacherRepository, TeacherRepository>();
        builder.Services.AddScoped<IStudentRepository, StudentRepository>();
        builder.Services.AddScoped<IClassRoomRepository, ClassRoomRepository>();

        builder.Services.AddScoped<IValidator<TeacherUpdateDto>, TeacherUpdateDtoValidator>();
        builder.Services.AddScoped<IValidator<TeacherCreateDto>, TeacherCreateDtoValidator>();

    }
}
