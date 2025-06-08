using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooManagement.Domain.Classes
{
    public class Enclosure
    {
        public int Id { get; private set; }
        public string Type { get; private set; }
        public int Size { get; private set; }
        public int CurrentAnimalCount => _animals.Count;
        public int MaxCapacity { get; private set; }
        private List<Animal> _animals;

        public Enclosure(int id, string type, int size, int maxCapacity)
        {
            Id = id;
            Type = type;
            Size = size;
            MaxCapacity = maxCapacity;
            _animals = new List<Animal>();
        }

        public void AddAnimal(Animal animal)
        {
            if (CurrentAnimalCount < MaxCapacity)
                _animals.Add(animal);
        }

        public void RemoveAnimal(Animal animal) => _animals.Remove(animal);

        public void Clean() => _animals.Clear();
    }
}
