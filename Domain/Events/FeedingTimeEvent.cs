using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooManagement.Domain.Events
{
    public class FeedingTimeEvent
    {
        public int AnimalId { get; }
        public DateTime FeedingTime { get; }

        public FeedingTimeEvent(int animalId, DateTime feedingTime)
        {
            AnimalId = animalId;
            FeedingTime = feedingTime;
        }
    }
}
