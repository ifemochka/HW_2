using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooManagement.Application.Interfaces;
using ZooManagement.Domain.Classes;

namespace ZooManagement.Infrastructure
{
    public class AnimalRepository : IAnimalRepository
    {
        private readonly List<Animal> _animals = new();

        public void Add(Animal animal) => _animals.Add(animal);

        public void Remove(int id) => _animals.RemoveAll(a => a.Id == id);

        public Animal GetById(int id) => _animals.FirstOrDefault(a => a.Id == id);
        public IEnumerable<Animal> GetAll() => _animals;
    }
}
