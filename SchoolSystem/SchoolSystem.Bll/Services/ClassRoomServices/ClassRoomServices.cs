using SchoolSystem.Bll.Dtos;
using SchoolSystem.Dal.Entities;
using SchoolSystem.Repository.Services.ClassRoomRepository;

namespace SchoolSystem.Bll.Services.ClassRoomServices;

public class ClassRoomServices : IClassRoomServices
{
    private readonly IClassRoomRepository _classRoomRepository;

    public ClassRoomServices(IClassRoomRepository classRoomRepository)
    {
        _classRoomRepository = classRoomRepository;
    }
    public async Task DeleteClassRoomAsync(long id)
    {
        var classRoom = await _classRoomRepository.SelectByIdAsync(id);
        if (classRoom == null)
            throw new KeyNotFoundException($"ClassRoom with ID {id} not found.");
        await _classRoomRepository.DeleteClassRoomAsync(id);

    }

    public async Task<List<ClassRoomGetDto>> GetAllClassRoomsAsync(bool includeTeachers = false, bool includeStudents = false)
    {

        var classRoom = await _classRoomRepository.GetAllClassRoomsAsync(includeTeachers, includeStudents);
        var classRoomDtos = classRoom.Select(cr => ConvertToClassRoomGetDto(cr)).ToList();
        if (classRoom == null || !classRoom.Any())
        {
            return new List<ClassRoomGetDto>();

        }

        return classRoomDtos;
    }

    public async Task<List<ClassRoomGetDto>> GetAllClassRoomsWithPaginationAsync(int skip, int take)
    {

        if (skip < 0)
        {
            throw new ArgumentException("Skip must be zero or greater.");
        }

        if (take <= 0)
        {

            throw new ArgumentException("Take must be greater than zero.");
        }

        var classRooms = await _classRoomRepository.GetAllClassRoomsWithPaginationAsync(skip, take);

        if (classRooms == null || !classRooms.Any())
        {
            return new List<ClassRoomGetDto>();
        }

        var classRoomDtos = classRooms
                .Select(cr => ConvertToClassRoomGetDto(cr))
                .Where(dto => dto != null)
                .ToList();

        return classRoomDtos;

    }

    public async Task<ClassRoomGetDto?> GetClassRoomByIdAsync(long id)
    {
        var classRoom = await _classRoomRepository.SelectByIdAsync(id);
        if (classRoom == null)
        {
            throw new KeyNotFoundException($"ClassRoom with ID {id} not found.");
        }
        var classRoomGetDto = ConvertToClassRoomGetDto(classRoom);
        return classRoomGetDto;
    }

    public async Task<long> InsertClassRoomAsync(ClassRoomCreateDto classRoomCreateDto)
    {
        var classRoom = ConvertToClassRoomEntity(classRoomCreateDto);
        var exists = await _classRoomRepository.ExistsByRoomNumberAsync(classRoomCreateDto.RoomNumber);
        if (exists)
        {
            throw new InvalidOperationException($"Room number {classRoomCreateDto.RoomNumber} is already exists");
        }
        var id = await _classRoomRepository.InsertClassRoomAsync(classRoom);
        return id;
    }

    public async Task UpdateClassRoomAsync(ClassRoomCreateDto classRoomCreateDto)
    {
        var classRoom = ConvertToClassRoomEntity(classRoomCreateDto);
        await _classRoomRepository.SelectByIdAsync(classRoom.ClassRoomId);
        await _classRoomRepository.UpdateClassRoomAsync(classRoom);
    }


    private ClassRoomGetDto ConvertToClassRoomGetDto(ClassRoom classRoom)
    {
        return new ClassRoomGetDto()
        {
            ClassRoomId = classRoom.ClassRoomId,
            RoomNumber = classRoom.RoomNumber,
        };
    }

    private ClassRoom ConvertToClassRoomEntity(ClassRoomCreateDto classRoomCreateDto)
    {
        return new ClassRoom()
        {
            RoomNumber = classRoomCreateDto.RoomNumber,
        };
    }


}
