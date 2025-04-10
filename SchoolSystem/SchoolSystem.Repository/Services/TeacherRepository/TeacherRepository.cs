using SchoolSystem.Dal.Entities;

namespace SchoolSystem.Repository.Services.TeacherRepository;

public class TeacherRepository : ITeacherRepository
{
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

    public Task<long> InsertTeacher(Teacher teacher)
    {
        throw new NotImplementedException();
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
