using SchoolSystem.Dal.Entities;

namespace SchoolSystem.Repository.Services.ClassRoomRepository;

public interface IClassRoomRepository
{
    Task<long> InsertClassRoom(ClassRoom classRoom);
    Task UpdateClassRoom(ClassRoom classRoom);
    Task DeleteClassRoom(long id);
    Task<ClassRoom?> SelectById(long id);
    Task<List<ClassRoom>> GetAllClassRooms(bool includeTeachers = false, bool includeStudents = false);
    Task<List<ClassRoom>> GetAllClassRoomsWithPagination(int skip, int take);
}