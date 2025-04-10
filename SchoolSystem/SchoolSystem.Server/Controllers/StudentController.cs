using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolSystem.Bll.Dtos;
using SchoolSystem.Bll.Services.StudentServices;

namespace SchoolSystem.Server.Controllers
{
    [Route("api/student")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentServices studentServices;

        public StudentController(IStudentServices studentServices)
        {
            this.studentServices = studentServices;
        }

        [HttpGet]
        public async Task<List<StudentGetDto>> GetAllStudents()
        {
            return await studentServices.GetAllStudents();
        }
    }
}
