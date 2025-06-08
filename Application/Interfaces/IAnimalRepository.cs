using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooManagement.Domain.Classes;

namespace ZooManagement.Application.Interfaces
{
    public interface IAnimalRepository
    {
        void Add(Animal animal);
        void Remove(int id);
        Animal GetById(int id);
        IEnumerable<Animal> GetAll();
    }
}
