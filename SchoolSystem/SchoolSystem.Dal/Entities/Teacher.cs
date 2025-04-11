namespace SchoolSystem.Dal.Entities;

public class Teacher
{
    public long TeacherId { get; set; }
    public string FirstName { get; set; } 
    public string LastName { get; set; }
    public int Age { get; set; }
    public string? PhoneNumber { get; set; }
    public string Grade { get; set; } 
    public string? Subject { get; set; }

    public ICollection<TeacherStudent> TeacherStudents { get; set; } 
    public ICollection<ClassRoomTeacher> ClassRoomTeachers { get; set; } 
}

