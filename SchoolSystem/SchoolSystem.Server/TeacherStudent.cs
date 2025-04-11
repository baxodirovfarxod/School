namespace SchoolSystem.Dal.Entities;

public class TeacherStudent
{
    public long TeacherId { get; set; }
    public Teacher Teacher { get; set; } = null!;

    public long StudentId { get; set; }
    public Student Student { get; set; } = null!;
}

