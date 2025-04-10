using SchoolSystem.Dal;
using SchoolSystem.Dal.Entities;

namespace SchoolSystem.Repository.Services.StudentRepository;

public class StudentRepository : IStudentRepository
{
    private readonly MainContext mainContext;

    public StudentRepository(MainContext mainContext)
    {
        this.mainContext = mainContext;
    }

    public Task DeleteStudent(long id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Student>> GetAllStudents(bool includeTeacher = false, bool includeClass = false)
    {
        return mainContext.Students.ToList();
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
