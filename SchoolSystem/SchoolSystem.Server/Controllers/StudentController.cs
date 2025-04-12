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
        private readonly IStudentServices _studentServices;
    }
}
