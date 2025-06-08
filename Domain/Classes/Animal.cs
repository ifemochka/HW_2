using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ZooManagement.Domain.Classes
{
    public class Animal
    {
        public int Id { get; private set; }
        public string Species { get; private set; }
        public string Name { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public string Gender { get; private set; }
        public string FavoriteFood { get; private set; }
        public bool IsHealthy { get; private set; }

        public Animal(int id, string species, string name, DateTime dateOfBirth, string gender, string favoriteFood)
        {
            Id = id;
            Species = species;
            Name = name;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            FavoriteFood = favoriteFood;
            IsHealthy = true;
        }

        public void Feed() => IsHealthy = true;

        public void Treat() => IsHealthy = true;

        public void MoveToEnclosure(Enclosure newEnclosure) => newEnclosure.AddAnimal(this);
    }
}
