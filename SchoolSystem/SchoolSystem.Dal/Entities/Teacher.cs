namespace SchoolSystem.Dal.Entities;

public class Teacher
{
    public long TeacherId { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public int Age { get; set; }
    public string? PhoneNumber { get; set; }
    public string Grade { get; set; } = null!;
    public string? Subject { get; set; }

    public ICollection<TeacherStudent> TeacherStudents { get; set; } = new List<TeacherStudent>();
    public ICollection<ClassRoomTeacher> ClassRoomTeachers { get; set; } = new List<ClassRoomTeacher>();
}

