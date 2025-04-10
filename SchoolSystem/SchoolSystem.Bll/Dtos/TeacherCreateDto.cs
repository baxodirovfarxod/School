namespace SchoolSystem.Bll.Dtos;

public class TeacherCreateDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string? PhoneNumber { get; set; }
    public string Grade { get; set; }
    public string? Subject { get; set; }
}
