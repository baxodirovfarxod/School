namespace SchoolSystem.Dal.Entities;

public class Student
{
    public long StudentId { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public int Age { get; set; }
    public string? PhoneNumber { get; set; }
    public string Grade { get; set; } = null!;

    public ICollection<TeacherStudent> TeacherStudents { get; set; } = new List<TeacherStudent>();
    public ICollection<ClassRoomStudent> ClassRoomStudents { get; set; } = new List<ClassRoomStudent>();
}

