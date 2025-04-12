using FluentValidation;
using SchoolSystem.Bll.Dtos;
using SchoolSystem.Dal.Entities;
using SchoolSystem.Repository.Services.TeacherRepository;

namespace SchoolSystem.Bll.Services.TeacherServices;

public class TeacherServices : ITeacherServices
{
    private readonly ITeacherRepository TeacherRepository;
    private readonly IValidator<TeacherCreateDto> CreateValidator;
    private readonly IValidator<TeacherUpdateDto> UpdateValidator;
    public TeacherServices(ITeacherRepository teacherRepository, IValidator<TeacherCreateDto> createValidator, IValidator<TeacherUpdateDto> updateValidator)
    {
        TeacherRepository = teacherRepository;
        CreateValidator = createValidator;
        UpdateValidator = updateValidator;
    }

    public async Task DeleteTeacherAsync(long id)
    {
        var teacher = await TeacherRepository.SelectByIdAsync(id);

        await TeacherRepository.DeleteTeacherAsync(id);
    }

    public async Task<List<TeacherGetDto>> GetAllTeachersAsync(bool includeStudent = false, bool includeClass = false)
    {
        var teachers = await TeacherRepository.GetAllTeachersAsync(includeStudent, includeClass);
        var teachersDtos = teachers.Select(teacher => ConvertToDto(teacher)).ToList();
        return teachersDtos;
    }

    public async Task<List<TeacherGetDto>> GetAllTeachersWithPaginationAsync(int skip, int take)
    {
        var teacher = await TeacherRepository.GetAllTeachersWithPaginationAsync(skip, take);
        var teachersDtos = teacher.Select(teacher => ConvertToDto(teacher)).ToList();
        return teachersDtos;
    }

    public async Task<TeacherGetDto?> GetTeacherByIdAsync(long id)
    {
        var teacher = await TeacherRepository.SelectByIdAsync(id);
        if (teacher == null)
        {
            throw new Exception($"Teacher with id {id} not found");
        }
        return ConvertToDto(teacher);
    }

    public async Task<long> InsertTeacherAsync(TeacherCreateDto teacherCreateDto)
    {
        var validationResult = CreateValidator.Validate(teacherCreateDto);

        if (!validationResult.IsValid)
        {
            throw new Exception("Validation error while insert teacher!");
        }

        var teacher = ConvertToEntity(teacherCreateDto);

        var id = await TeacherRepository.InsertTeacherAsync(teacher);

        return id;
    }

    public async Task UpdateTeacherAsync(TeacherUpdateDto teacherUpdateDto)
    {
        var validationResult = UpdateValidator.Validate(teacherUpdateDto);

        if (!validationResult.IsValid)
        {
            throw new Exception("Validation error while update teacher!");
        }
        var teacher = ConvertToEntity(teacherUpdateDto);

        await TeacherRepository.UpdateTeacherAsync(teacher);
    }

    private Teacher ConvertToEntity(TeacherCreateDto teacherCreateDto)
    {
        return new Teacher
        {
            FirstName = teacherCreateDto.FirstName,
            LastName = teacherCreateDto.LastName,
            Age = teacherCreateDto.Age,
            PhoneNumber = teacherCreateDto.PhoneNumber,
            Grade = teacherCreateDto.Grade,
            Subject = teacherCreateDto.Subject
        };
    }
    private Teacher ConvertToEntity(TeacherUpdateDto teacherUpdateDto)
    {
        return new Teacher
        {
            TeacherId = teacherUpdateDto.Id,
            FirstName = teacherUpdateDto.FirstName,
            LastName = teacherUpdateDto.LastName,
            Age = teacherUpdateDto.Age,
            PhoneNumber = teacherUpdateDto.PhoneNumber,
            Grade = teacherUpdateDto.Grade,
            Subject = teacherUpdateDto.Subject
        };
    }
    private TeacherGetDto ConvertToDto(Teacher teacher)
    {
        return new TeacherGetDto
        {
            TeacherId = teacher.TeacherId,
            FirstName = teacher.FirstName,
            LastName = teacher.LastName,
            Age = teacher.Age,
            PhoneNumber = teacher.PhoneNumber,
            Grade = teacher.Grade,
            Subject = teacher.Subject
        };
    }
}
