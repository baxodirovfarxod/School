namespace SchoolSystem.Dal.Entities;

public class ClassRoom
{
    public long ClassRoomId { get; set; }
    public int RoomNumber { get; set; }

    public ICollection<Teacher> Teachers { get; set; }
    public ICollection<Student> Students { get; set; } 
}

