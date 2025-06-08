using Microsoft.AspNetCore.Mvc;
using ZooManagement.Application.Interfaces;
using ZooManagement.Domain.Classes;

[ApiController]
[Route("api/[controller]")]
public class EnclosuresController : ControllerBase
{
    private readonly IEnclosureRepository _enclosureRepository;

    public EnclosuresController(IEnclosureRepository enclosureRepository)
    {
        _enclosureRepository = enclosureRepository;
    }

    [HttpGet]
    public IActionResult GetAll() => Ok(_enclosureRepository.GetAll());

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var enclosure = _enclosureRepository.GetById(id);
        if (enclosure == null) return NotFound();
        return Ok(enclosure);
    }

    [HttpPost]
    public IActionResult Create([FromBody] EnclosureDto dto)
    {
        var enclosure = new Enclosure(dto.Id, dto.Type, dto.Size, dto.MaxCapacity);
        _enclosureRepository.Add(enclosure);
        return CreatedAtAction(nameof(GetById), new { id = enclosure.Id }, enclosure);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var enclosure = _enclosureRepository.GetById(id);
        if (enclosure == null) return NotFound();

        _enclosureRepository.Remove(id);
        return NoContent();
    }

    [HttpPost("{id}/clean")]
    public IActionResult Clean(int id)
    {
        var enclosure = _enclosureRepository.GetById(id);
        if (enclosure == null) return NotFound();

        enclosure.Clean();
        return Ok();
    }
}

public class EnclosureDto
{
    public int Id { get; set; }
    public string Type { get; set; } = null!;
    public int Size { get; set; }
    public int MaxCapacity { get; set; }
}
