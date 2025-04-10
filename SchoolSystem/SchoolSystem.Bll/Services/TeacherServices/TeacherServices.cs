using SchoolSystem.Bll.Dtos;

namespace SchoolSystem.Bll.Services.TeacherServices;

public class TeacherServices : ITeacherServices
{
    public Task DeleteTeacher(long id)
    {
        throw new NotImplementedException();
    }

    public Task<List<TeacherGetDto>> GetAllTeachers(bool includeStudent = false, bool includeClass = false)
    {
        throw new NotImplementedException();
    }

    public Task<List<TeacherGetDto>> GetAllTeachersWithPagination(int skip, int take)
    {
        throw new NotImplementedException();
    }

    public Task<TeacherGetDto?> GetTeacherById(long id)
    {
        throw new NotImplementedException();
    }

    public Task<long> InsertTeacher(TeacherCreateDto teacherCreateDto)
    {
        throw new NotImplementedException();
    }

    public Task UpdateTeacher(TeacherCreateDto teacherCreateDto)
    {
        throw new NotImplementedException();
    }
}
