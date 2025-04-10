namespace SchoolSystem.Dal.Entities;

public class Student
{
    public long StudentId { get; set; }
    public string FirstName { get; set; } 
    public string LastName { get; set; } 
    public int Age { get; set; }
    public string? PhoneNumber { get; set; }
    public string Grade { get; set; } 

    public ICollection<Teacher> Teacher { get; set; } 
    public ICollection<ClassRoom> ClassRoom { get; set; }
}

