namespace SchoolSystem.Bll.Dtos;

public class StudentCreateDto 
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string? PhoneNumber { get; set; }
    public string Grade { get; set; }
}
