using SchoolSystem.Dal.Entities;

namespace SchoolSystem.Repository.Services.StudentRepository;

public class StudentRepository : IStudentRepository
{
    public Task DeleteStudent(long id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Student>> GetAllStudents(bool includeTeacher = false, bool includeClass = false)
    {
        throw new NotImplementedException();
    }

    public Task<List<Student>> GetAllStudentsWithPagination(int skip, int take)
    {
        throw new NotImplementedException();
    }

    public Task<long> InsertStudent(Student student)
    {
        throw new NotImplementedException();
    }

    public Task<Student?> SelectById(long id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateStudent(Student student)
    {
        throw new NotImplementedException();
    }
}
