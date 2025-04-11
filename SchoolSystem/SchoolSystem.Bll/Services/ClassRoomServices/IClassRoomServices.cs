using SchoolSystem.Bll.Dtos;

namespace SchoolSystem.Bll.Services.ClassRoomServices;

public interface IClassRoomServices
{
    Task<long> InsertClassRoomAsync(ClassRoomCreateDto classRoomCreateDto);
    Task UpdateClassRoomAsync(ClassRoomCreateDto classRoomCreateDto);
    Task DeleteClassRoomAsync(long id);
    Task<ClassRoomGetDto?> GetClassRoomByIdAsync(long id);
    Task<List<ClassRoomGetDto>> GetAllClassRoomsWithPaginationAsync(int skip, int take);
    Task<List<ClassRoomGetDto>> GetAllClassRoomsAsync(bool includeTeachers = false, bool includeStudents = false);
}