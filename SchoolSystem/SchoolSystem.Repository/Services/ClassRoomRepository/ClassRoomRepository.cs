using SchoolSystem.Dal.Entities;

namespace SchoolSystem.Repository.Services.ClassRoomRepository;

public class ClassRoomRepository : IClassRoomRepository
{
    public Task DeleteClassRoom(long id)
    {
        throw new NotImplementedException();
    }

    public Task<List<ClassRoom>> GetAllClassRooms(bool includeTeachers = false, bool includeStudents = false)
    {
        throw new NotImplementedException();
    }

    public Task<List<ClassRoom>> GetAllClassRoomsWithPagination(int skip, int take)
    {
        throw new NotImplementedException();
    }

    public Task<long> InsertClassRoom(ClassRoom classRoom)
    {
        throw new NotImplementedException();
    }

    public Task<ClassRoom?> SelectById(long id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateClassRoom(ClassRoom classRoom)
    {
        throw new NotImplementedException();
    }
}
