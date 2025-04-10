namespace SchoolSystem.Bll.Dtos;

public class StudentGetDto : StudentCreateDto
{
    public long StudentId { get; set; }
    public ICollection<TeacherGetDto> Teacher { get; set; }
    public ICollection<ClassRoomGetDto> ClassRoom { get; set; }
}
