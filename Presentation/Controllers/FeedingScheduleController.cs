using Microsoft.AspNetCore.Mvc;
using ZooManagement.Application.Interfaces;
using ZooManagement.Domain.Classes;

[ApiController]
[Route("api/[controller]")]
public class FeedingSchedulesController : ControllerBase
{
    private readonly IFeedingScheduleRepository _feedingScheduleRepository;

    public FeedingSchedulesController(IFeedingScheduleRepository feedingScheduleRepository)
    {
        _feedingScheduleRepository = feedingScheduleRepository;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var schedules = _feedingScheduleRepository.GetAll();
        return Ok(schedules);
    }

  
    [HttpPost]
    public IActionResult Create([FromBody] FeedingScheduleDto dto)
    {
        var feedingSchedule = new FeedingSchedule(
            dto.Id,
            dto.Animal, 
            dto.FeedingTime,
            dto.FoodType);

        _feedingScheduleRepository.Add(feedingSchedule);

        return CreatedAtAction(nameof(GetAll), null, feedingSchedule);
    }
}

public class FeedingScheduleDto
{
    public int Id { get; set; }
    public Animal Animal { get; set; } = null!;
    public DateTime FeedingTime { get; set; }
    public string FoodType { get; set; }
}
