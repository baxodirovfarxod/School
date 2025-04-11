using SchoolSystem.Dal.Entities;

namespace SchoolSystem.Repository.Services.ClassRoomRepository;

public interface IClassRoomRepository
{
    Task<long> InsertClassRoomAsync(ClassRoom classRoom);
    Task UpdateClassRoomAsync(ClassRoom classRoom);
    Task DeleteClassRoomAsync(long id);
    Task<ClassRoom?> SelectByIdAsync(long id);
    Task<List<ClassRoom>> GetAllClassRoomsAsync(bool includeTeachers = false, bool includeStudents = false);
    Task<List<ClassRoom>> GetAllClassRoomsWithPaginationAsync(int skip, int take);
    Task<bool> ExistsByRoomNumberAsync(int roomNumber);
}