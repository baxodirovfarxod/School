using SchoolSystem.Dal.Entities;

namespace SchoolSystem.Repository.Services.TeacherRepository;

public interface ITeacherRepository
{
    Task<long> InsertTeacherAsync(Teacher teacher);
    Task UpdateTeacherAsync(Teacher teacher);
    Task DeleteTeacherAsync(long id);
    Task<Teacher?> SelectByIdAsync(long id);
    Task<List<Teacher>> GetAllTeachersAsync(bool includeStudent = false, bool includeClass = false);
    Task<List<Teacher>> GetAllTeachersWithPaginationAsync(int skip, int take);
}