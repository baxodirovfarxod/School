namespace SchoolSystem.Dal.Entities;

public class ClassRoomStudent
{
    public long ClassRoomId { get; set; }
    public ClassRoom ClassRoom { get; set; } = null!;

    public long StudentId { get; set; }
    public Student Student { get; set; } = null!;
}

