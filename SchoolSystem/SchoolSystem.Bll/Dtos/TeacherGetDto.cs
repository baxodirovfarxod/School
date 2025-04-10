namespace SchoolSystem.Bll.Dtos;

public class TeacherGetDto : TeacherCreateDto
{
    public long TeacherId { get; set; }
    public ICollection<StudentGetDto> Students { get; set; }
    public ICollection<ClassRoomGetDto> ClassRoom { get; set; }
}
