using SchoolSystem.Bll.Dtos;

namespace SchoolSystem.Bll.Services.ClassRoomServices;

public interface IClassRoomServices
{
    Task<long> InsertClassRoom(ClassRoomCreateDto classRoomCreateDto);
    Task UpdateClassRoom(ClassRoomCreateDto classRoomCreateDto);
    Task DeleteClassRoom(long id);
    Task<ClassRoomGetDto?> GetClassRoomById(long id);
    Task<List<ClassRoomGetDto>> GetAllClassRoomsWithPagination(int skip, int take);
    Task<List<ClassRoomGetDto>> GetAllClassRooms(bool includeTeachers = false, bool includeStudents = false);
}