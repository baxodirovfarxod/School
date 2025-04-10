using Microsoft.EntityFrameworkCore;
using SchoolSystem.Dal.Entities; 

namespace SchoolSystem.Dal;

public class MainContext : DbContext
{
    public MainContext(DbContextOptions<MainContext> options)
        : base(options)
    {
    }

    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<ClassRoom> ClassRooms { get; set; }

    public DbSet<TeacherStudent> TeacherStudents { get; set; }
    public DbSet<ClassRoomTeacher> ClassRoomTeachers { get; set; }
    public DbSet<ClassRoomStudent> ClassRoomStudents { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Teacher>().ToTable("Teachers");
        modelBuilder.Entity<Student>().ToTable("Students");
        modelBuilder.Entity<ClassRoom>().ToTable("ClassRooms");

        modelBuilder.Entity<TeacherStudent>().ToTable("TeacherStudent");
        modelBuilder.Entity<ClassRoomTeacher>().ToTable("ClassRoomTeachers");
        modelBuilder.Entity<ClassRoomStudent>().ToTable("ClassRoomStudents");
    }
}
