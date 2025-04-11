using Microsoft.EntityFrameworkCore;
using SchoolSystem.Dal.Entities;

namespace SchoolSystem.Repository.Services.ClassRoomRepository;

public class ClassRoomRepository : IClassRoomRepository
{
    
    public Task DeleteClassRoomAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> ExistsByRoomNumberAsync(int roomNumber)
    {
        throw new NotImplementedException();
    }

    public Task<List<ClassRoom>> GetAllClassRoomsAsync(bool includeTeachers = false, bool includeStudents = false)
    {
        throw new NotImplementedException();
    }

    public Task<List<ClassRoom>> GetAllClassRoomsWithPaginationAsync(int skip, int take)
    {
        throw new NotImplementedException();
    }

    public Task<long> InsertClassRoomAsync(ClassRoom classRoom)
    {
        throw new NotImplementedException();
    }

    public Task<ClassRoom?> SelectByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateClassRoomAsync(ClassRoom classRoom)
    {
        throw new NotImplementedException();
    }
    

}
