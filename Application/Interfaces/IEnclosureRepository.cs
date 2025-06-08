using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooManagement.Domain.Classes;

namespace ZooManagement.Application.Interfaces
{
    public interface IEnclosureRepository
    {
        void Add(Enclosure enclosure);
        void Remove(int id);
        Enclosure GetById(int id);
        IEnumerable<Enclosure> GetAll();
    }
}
