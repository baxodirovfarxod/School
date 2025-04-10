namespace SchoolSystem.Dal.Entities;

public class ClassRoom
{
    public long ClassRoomId { get; set; }
    public int RoomNumber { get; set; }

    public ICollection<ClassRoomTeacher> ClassRoomTeachers { get; set; } = new List<ClassRoomTeacher>();
    public ICollection<ClassRoomStudent> ClassRoomStudents { get; set; } = new List<ClassRoomStudent>();
}

