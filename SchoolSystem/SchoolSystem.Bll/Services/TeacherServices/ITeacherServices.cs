using SchoolSystem.Bll.Dtos;

namespace SchoolSystem.Bll.Services.TeacherServices;

public interface ITeacherServices
{
    Task<long> InsertTeacher(TeacherCreateDto teacherCreateDto);
    Task UpdateTeacher(TeacherCreateDto teacherCreateDto);
    Task DeleteTeacher(long id);
    Task<TeacherGetDto?> GetTeacherById(long id);
    Task<List<TeacherGetDto>> GetAllTeachers(bool includeStudent = false, bool includeClass = false);
    Task<List<TeacherGetDto>> GetAllTeachersWithPagination(int skip, int take);
}