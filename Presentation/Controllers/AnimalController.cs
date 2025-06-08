using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using ZooManagement.Application.Interfaces;
using ZooManagement.Domain.Classes;

[ApiController]
[Route("api/[controller]")]
public class AnimalsController : ControllerBase
{
    private readonly IAnimalRepository _animalRepository;

    public AnimalsController(IAnimalRepository animalRepository)
    {
        _animalRepository = animalRepository;
    }

    [HttpGet]
    public IActionResult GetAll() => Ok(_animalRepository.GetAll());

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var animal = _animalRepository.GetById(id);
        if (animal == null) return NotFound();
        return Ok(animal);
    }

    [HttpPost]
    public IActionResult Create([FromBody] AnimalDto dto)
    {
        var animal = new Animal(
            id: dto.Id,
            species: dto.Species,
            name: dto.Name,
            dateOfBirth: dto.DateOfBirth,
            gender: dto.Gender,
            favoriteFood: dto.FavoriteFood);

        _animalRepository.Add(animal);
        return CreatedAtAction(nameof(GetById), new { id = animal.Id }, animal);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var animal = _animalRepository.GetById(id);
        if (animal == null) return NotFound();

        _animalRepository.Remove(id);
        return NoContent();
    }
}

public class AnimalDto
{
    public int Id { get; set; }
    public string Species { get; set; }
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Gender { get; set; }
    public string FavoriteFood { get; set; }
}
