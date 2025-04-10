using SchoolSystem.Bll.Dtos;
using SchoolSystem.Repository.Services.StudentRepository;

namespace SchoolSystem.Bll.Services.StudentServices;

public class StudentServices : IStudentServices
{
    private readonly IStudentRepository studentRepository;

    public StudentServices(IStudentRepository studentRepository)
    {
        this.studentRepository = studentRepository;
    }

    public Task DeleteStudent(long id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<StudentGetDto>> GetAllStudents(bool includeTeacher = false, bool includeClass = false)
    {
        throw new NotImplementedException();
    }

    public Task<List<StudentGetDto>> GetAllStudentsWithPagination(int skip, int take)
    {
        throw new NotImplementedException();
    }

    public Task<StudentGetDto?> GetStudentById(long id)
    {
        throw new NotImplementedException();
    }

    public Task<long> InsertStudent(StudentCreateDto studentCreateDto)
    {
        throw new NotImplementedException();
    }

    public Task UpdateStudent(StudentCreateDto studentCreateDto)
    {
        throw new NotImplementedException();
    }
}
