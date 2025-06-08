using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooManagement.Domain;
using ZooManagement.Application.Interfaces;
namespace ZooManagement.Application.Services
{
    public class ZooStatisticsService
    {
        private readonly IAnimalRepository _animalRepository;
        private readonly IEnclosureRepository _enclosureRepository;

        public ZooStatisticsService(IAnimalRepository animalRepository, IEnclosureRepository enclosureRepository)
        {
            _animalRepository = animalRepository;
            _enclosureRepository = enclosureRepository;
        }

        public (int TotalAnimals, int FreeEnclosures) GetStatistics()
        {
            var totalAnimals = _animalRepository.GetAll().Count();
            var freeEnclosures = _enclosureRepository.GetAll().Count(e => e.CurrentAnimalCount < e.MaxCapacity);

            return (totalAnimals, freeEnclosures);
        }
    }
}
