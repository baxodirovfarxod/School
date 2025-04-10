using Microsoft.EntityFrameworkCore;
using SchoolSystem.Dal;
using SchoolSystem.Dal.Entities;

namespace SchoolSystem.Repository.Services.TeacherRepository;

public class TeacherRepository : ITeacherRepository
{
    private readonly MainContext MainContext;

    public TeacherRepository(MainContext mainContext)
    {
        MainContext = mainContext;
    }

    public async Task DeleteTeacherAsync(long id)
    {
        var teacher = await SelectByIdAsync(id);
        MainContext.Teachers.Remove(teacher);
        await MainContext.SaveChangesAsync();
    }

    public async Task<List<Teacher>> GetAllTeachersAsync(bool includeStudent = false, bool includeClass = false)
    {
        var query = MainContext.Teachers.AsQueryable();

        if (includeStudent)
        {
            query = query.Include(t => t.Students);
        }
        if (includeClass)
        {
            query = query.Include(t => t.ClassRoom);
        }
        return await query.ToListAsync();
    }

    public async Task<List<Teacher>> GetAllTeachersWithPaginationAsync(int skip, int take)
    {
        if (take < 0 || skip < 0)
        {
            throw new ArgumentOutOfRangeException("Skip and take don't be negative");
        }

        var query = MainContext.Teachers.AsQueryable();

        if (skip > 0)
        {
            query = query.Skip(skip);
        }
        if (take > 0)
        {
            query = query.Take(take);
        }

        return await query.ToListAsync();
    }

    public async Task<long> InsertTeacherAsync(Teacher teacher)
    {
        await MainContext.Teachers.AddAsync(teacher);
        await MainContext.SaveChangesAsync();
        return teacher.TeacherId;
    }

    public async Task<Teacher?> SelectByIdAsync(long id)
    {
        var teacher = await MainContext.Teachers.FirstOrDefaultAsync(t => t.TeacherId == id);
        if (teacher == null)
        {
            throw new Exception($"Teacher not found with {id}");
        }
        return teacher;
    }

    public async Task UpdateTeacherAsync(Teacher teacher)
    {
        var updateTeacher = MainContext.Teachers.Update(teacher);
        await MainContext.SaveChangesAsync();
    }
}
