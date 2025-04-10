namespace SchoolSystem.Bll.Dtos;

public class ClassRoomGetDto : ClassRoomCreateDto
{
    public ICollection<TeacherGetDto> Teachers { get; set; }
    public ICollection<StudentGetDto> Students { get; set; }
}
