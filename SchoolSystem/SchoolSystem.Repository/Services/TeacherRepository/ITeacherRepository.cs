using SchoolSystem.Dal.Entities;

namespace SchoolSystem.Repository.Services.TeacherRepository;

public interface ITeacherRepository
{
    Task<long> InsertTeacher(Teacher teacher);
    Task UpdateTeacher(Teacher teacher);
    Task DeleteTeacher(long id);
    Task<Teacher?> SelectById(long id);
    Task<List<Teacher>> GetAllTeachers(bool includeStudent = false, bool includeClass = false);
    Task<List<Teacher>> GetAllTeachersWithPeganation(int skip, int take);
}