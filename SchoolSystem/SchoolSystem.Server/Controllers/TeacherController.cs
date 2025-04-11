using Microsoft.AspNetCore.Mvc;
using SchoolSystem.Bll.Dtos;
using SchoolSystem.Bll.Services.TeacherServices;

namespace SchoolSystem.Server.Controllers;

[Route("api/teacher")]
[ApiController]
public class TeacherController : ControllerBase
{
    private readonly ITeacherServices TeacherServices;

    public TeacherController(ITeacherServices teacherServices)
    {
        TeacherServices = teacherServices;
    }

    [HttpPost("add")]
    public async Task<long> AddTeacher(TeacherCreateDto teacherCreateDto)
    {
       return await TeacherServices.InsertTeacherAsync(teacherCreateDto);
    }


    [HttpPut("update")]
    public async Task UpdateTeacher(TeacherUpdateDto teacherUpdateDto)
    {
        await TeacherServices.UpdateTeacherAsync(teacherUpdateDto);
    }

    [HttpDelete("delete")]
    public async Task DeleteTeacher(long id)
    {
        await TeacherServices.DeleteTeacherAsync(id);
    }

    [HttpGet("getById")]
    public async Task<TeacherGetDto?> GetTeacherById(long id)
    {
        return await TeacherServices.GetTeacherByIdAsync(id);
    }

    [HttpGet("getAll")]
    public async Task<List<TeacherGetDto>> GetAllTeachers(bool includeStudent = false, bool includeClass = false)
    {
        return await TeacherServices.GetAllTeachersAsync(includeStudent, includeClass);
    }

    [HttpGet("getAllWithPagination")]
    public async Task<List<TeacherGetDto>> GetAllTeachersWithPagination(int skip, int take)
    {
        return await TeacherServices.GetAllTeachersWithPaginationAsync(skip, take);
    }
}
