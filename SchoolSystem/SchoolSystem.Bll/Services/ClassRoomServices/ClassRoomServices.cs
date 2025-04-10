using SchoolSystem.Bll.Dtos;

namespace SchoolSystem.Bll.Services.ClassRoomServices;

public class ClassRoomServices : IClassRoomServices
{
    public Task DeleteClassRoom(long id)
    {
        throw new NotImplementedException();
    }

    public Task<List<ClassRoomGetDto>> GetAllClassRooms(bool includeTeachers = false, bool includeStudents = false)
    {
        throw new NotImplementedException();
    }

    public Task<List<ClassRoomGetDto>> GetAllClassRoomsWithPagination(int skip, int take)
    {
        throw new NotImplementedException();
    }

    public Task<ClassRoomGetDto?> GetClassRoomById(long id)
    {
        throw new NotImplementedException();
    }

    public Task<long> InsertClassRoom(ClassRoomCreateDto classRoomCreateDto)
    {
        throw new NotImplementedException();
    }

    public Task UpdateClassRoom(ClassRoomCreateDto classRoomCreateDto)
    {
        throw new NotImplementedException();
    }
}
