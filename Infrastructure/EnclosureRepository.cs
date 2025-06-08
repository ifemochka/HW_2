using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooManagement.Application.Interfaces;
using ZooManagement.Domain.Classes;

namespace ZooManagement.Infrastructure
{
    public class EnclosureRepository : IEnclosureRepository
    {
        private readonly List<Enclosure> _enclosures = new();

        public void Add(Enclosure enclosure) => _enclosures.Add(enclosure);

        public void Remove(int id) => _enclosures.RemoveAll(e => e.Id == id);

        public Enclosure GetById(int id) => _enclosures.FirstOrDefault(e => e.Id == id);

        public IEnumerable<Enclosure> GetAll() => _enclosures;
    }
}
