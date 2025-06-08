using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooManagement.Domain.Events
{
    public class AnimalMovedEvent
    {
        public int AnimalId { get; }
        public int FromEnclosureId { get; }
        public int ToEnclosureId { get; }

        public AnimalMovedEvent(int animalId, int fromEnclosureId, int toEnclosureId)
        {
            AnimalId = animalId;
            FromEnclosureId = fromEnclosureId;
            ToEnclosureId = toEnclosureId;
        }
    }
}
