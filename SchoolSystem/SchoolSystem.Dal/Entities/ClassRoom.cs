namespace SchoolSystem.Dal.Entities;

public class ClassRoom
{
    public long ClassRoomId { get; set; }
    public int RoomNumber { get; set; }

    public ICollection<ClassRoomStudent> ClassRoomStudent { get; set; }
    public ICollection<ClassRoomTeacher> ClassRoomTeacher { get; set; }
}

