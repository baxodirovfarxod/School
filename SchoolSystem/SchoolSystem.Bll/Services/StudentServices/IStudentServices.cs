using SchoolSystem.Bll.Dtos;

namespace SchoolSystem.Bll.Services.StudentServices;

public interface IStudentServices
{
    Task<long> InsertStudent(StudentCreateDto studentCreateDto);
    Task UpdateStudent(StudentCreateDto studentCreateDto);
    Task DeleteStudent(long id);
    Task<StudentGetDto?> GetStudentById(long id);
    Task<List<StudentGetDto>> GetAllStudents(bool includeTeacher = false, bool includeClass = false);
    Task<List<StudentGetDto>> GetAllStudentsWithPagination(int skip, int take);
}