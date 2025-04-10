using SchoolSystem.Dal.Entities;

namespace SchoolSystem.Repository.Services.StudentRepository;

public interface IStudentRepository
{
    Task<long> InsertStudent(Student student);
    Task UpdateStudent(Student student);
    Task DeleteStudent(long id);
    Task<Student?> SelectById(long id);
    Task<List<Student>> GetAllStudents(bool includeTeacher = false, bool includeClass = false);
    Task<List<Student>> GetAllStudentsWithPagination(int skip, int take);
}