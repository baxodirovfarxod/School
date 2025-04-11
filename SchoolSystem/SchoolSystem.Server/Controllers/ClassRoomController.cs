using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolSystem.Bll.Dtos;
using SchoolSystem.Bll.Services.ClassRoomServices;
using SchoolSystem.Bll.Services.TeacherServices;

namespace SchoolSystem.Server.Controllers
{
    [Route("api/classroom")]
    [ApiController]
    public class ClassRoomController : ControllerBase
    {
        private readonly IClassRoomServices _classRoomService;
        public ClassRoomController(IClassRoomServices classRoomService)
        {
            _classRoomService = classRoomService;
        }
        [HttpPost("addClassRoom")]
        public async Task<long> AddClassRoom(ClassRoomCreateDto classRoomCreateDto)
        {
            var id = await _classRoomService.InsertClassRoomAsync(classRoomCreateDto);
            return id;
        }
        [HttpGet("getAllClassRooms")]
        public async Task<List<ClassRoomGetDto>> GetAllClassRooms()
        {
            var classRooms = await _classRoomService.GetAllClassRoomsAsync();
            return classRooms;
        }
        [HttpPut("updateClassRoom")]
        public async Task PutMusic(ClassRoomGetDto classRoomGetDto)
        {
            await _classRoomService.UpdateClassRoomAsync(classRoomGetDto);
        }
        [HttpDelete("deleteClassRoom")]
        public async Task DeleteClassRoom(long id)
        {
            await _classRoomService.DeleteClassRoomAsync(id);
        }
        [HttpGet("getAllClassRoomById")]
        public async Task<ClassRoomGetDto?> GetAllClassRoomById(long id)
        {
            return await _classRoomService.GetClassRoomByIdAsync(id);

        }

        [HttpGet("getAllClassRoomsWithPagination")]
        public async Task<List<ClassRoomGetDto>> GetAllClassRoomsWithPagination(int skip, int take)
        {
            return await _classRoomService.GetAllClassRoomsWithPaginationAsync(skip, take);
        }
    }
}
