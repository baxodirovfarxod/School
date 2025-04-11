using SchoolSystem.Bll.Dtos;

namespace SchoolSystem.Bll.Services.TeacherServices;

public interface ITeacherServices
{
    Task<long> InsertTeacherAsync(TeacherCreateDto teacherCreateDto);
    Task UpdateTeacherAsync(TeacherUpdateDto teacherUpdateDto);
    Task DeleteTeacherAsync(long id);
    Task<TeacherGetDto?> GetTeacherByIdAsync(long id);
    Task<List<TeacherGetDto>> GetAllTeachersAsync(bool includeStudent = false, bool includeClass = false);
    Task<List<TeacherGetDto>> GetAllTeachersWithPaginationAsync(int skip, int take);
}