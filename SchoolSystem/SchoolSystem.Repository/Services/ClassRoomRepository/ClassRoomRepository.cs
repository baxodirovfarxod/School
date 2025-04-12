using Microsoft.EntityFrameworkCore;
using SchoolSystem.Dal;
using SchoolSystem.Dal.Entities;

namespace SchoolSystem.Repository.Services.ClassRoomRepository;

public class ClassRoomRepository : IClassRoomRepository
{
    private readonly MainContext _mainContext;

    public ClassRoomRepository(MainContext mainContext)
    {
        _mainContext = mainContext;
    }
    public async Task DeleteClassRoomAsync(long id)
    {
        var classRoom = await _mainContext.ClassRooms.FindAsync(id);      
        if (classRoom is not null)
        {
            _mainContext.ClassRooms.Remove(classRoom);
            await _mainContext.SaveChangesAsync();
        }
    }

    public async Task<bool> ExistsByRoomNumberAsync(int roomNumber)
    {
        return await _mainContext.ClassRooms.AnyAsync(c => c.RoomNumber == roomNumber);
    }

    public async Task<List<ClassRoom>> GetAllClassRoomsAsync(bool includeTeachers = false, bool includeStudents = false)
    {
        IQueryable<ClassRoom> query = _mainContext.ClassRooms;

        if (includeTeachers)
            query = query.Include(c => c.Teachers);

        if (includeStudents)
            query = query.Include(c => c.Students);

        return await query.ToListAsync();
    }

    public async Task<List<ClassRoom>> GetAllClassRoomsWithPaginationAsync(int skip, int take)
    {
        var res =  await _mainContext.ClassRooms
                    .Skip(skip)
                    .Take(take)
                    .ToListAsync();

        return res;
    }

    public async Task<long> InsertClassRoomAsync(ClassRoom classRoom)
    {
        await _mainContext.ClassRooms.AddAsync(classRoom);
        await _mainContext.SaveChangesAsync();
        return classRoom.ClassRoomId;
    }

    public async Task<ClassRoom?> SelectByIdAsync(long id)
    {
         var res = await _mainContext.ClassRooms
                    .Include(c => c.Teachers) 
                    .Include(c => c.Students) 
                    .FirstOrDefaultAsync(c => c.ClassRoomId == id);

        return res;
    }

    public async Task UpdateClassRoomAsync(ClassRoom classRoom)
    {
        _mainContext.ClassRooms.Update(classRoom);
        await _mainContext.SaveChangesAsync();
    }
    

}
