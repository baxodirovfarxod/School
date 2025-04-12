using SchoolSystem.Dal;
using SchoolSystem.Dal.Entities;
using Microsoft.EntityFrameworkCore;


namespace SchoolSystem.Repository.Services.StudentRepository;

public class StudentRepository : IStudentRepository
{
    private readonly MainContext mainContext;

    public StudentRepository(MainContext mainContext)
    {
        this.mainContext = mainContext;
    }

    public async Task DeleteStudent(long id)
    {
        var student = await mainContext.Students.FindAsync(id);
        if (student != null)
        {
            mainContext.Students.Remove(student);
            await mainContext.SaveChangesAsync();
        }
    }

    public async Task<List<Student>> GetAllStudents(bool includeTeacher = false, bool includeClass = false)
    {
        IQueryable<Student> query = mainContext.Students;

        if (includeTeacher)
            query = query.Include(s => s.TeacherStudents);

        if (includeClass)
            query = query.Include(s => s.ClassRoomStudent);

        return await query.ToListAsync();
    }

    public Task<List<Student>> GetAllStudentsWithPagination(int skip, int take)
    {
         var res =  mainContext.Students
                    .Skip(skip)
                    .Take(take)
                    .ToListAsync();

        return res;
    }

    public async Task<long> InsertStudent(Student student)
    {
        await mainContext.Students.AddAsync(student);
        await mainContext.SaveChangesAsync();
        return student.StudentId;
    }

    public async Task<Student?> SelectById(long id)
    {
        var res = await mainContext.Students
                .Include(s => s.TeacherStudents)
                .Include(s => s.ClassRoomStudent) 
                .FirstOrDefaultAsync(s => s.StudentId == id);

        return res;
    }

    public async Task UpdateStudent(Student student)
    {
        mainContext.Students.Update(student);
        await mainContext.SaveChangesAsync();
    }
}
