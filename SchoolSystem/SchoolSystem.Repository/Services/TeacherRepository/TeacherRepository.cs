using SchoolSystem.Dal;
using SchoolSystem.Dal.Entities;

namespace SchoolSystem.Repository.Services.TeacherRepository;

public class TeacherRepository : ITeacherRepository
{
    private readonly MainContext MainContext;

    public TeacherRepository(MainContext mainContext)
    {
        MainContext = mainContext;
    }

    public Task DeleteTeacher(long id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Teacher>> GetAllTeachers(bool includeStudent = false, bool includeClass = false)
    {
        throw new NotImplementedException();
    }

    public Task<List<Teacher>> GetAllTeachersWithPeganation(int skip, int take)
    {
        throw new NotImplementedException();
    }

    public async Task<long> InsertTeacher(Teacher teacher)
    {
        await MainContext.Teachers.AddAsync(teacher);
        await MainContext.SaveChangesAsync();
        return teacher.TeacherId;
    }

    public Task<Teacher?> SelectById(long id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateTeacher(Teacher teacher)
    {
        throw new NotImplementedException();
    }
}
