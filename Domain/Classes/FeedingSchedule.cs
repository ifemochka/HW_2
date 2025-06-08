using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooManagement.Domain.Classes
{
    public class FeedingSchedule
    {
        public int Id { get; private set; }
        public Animal Animal { get; private set; }
        public DateTime FeedingTime { get; private set; }
        public string FoodType { get; private set; }

        public FeedingSchedule(int id, Animal animal, DateTime feedingTime, string foodType)
        {
            Id = id;
            Animal = animal;
            FeedingTime = feedingTime;
            FoodType = foodType;
        }

        public void ChangeSchedule(DateTime newFeedingTime) => FeedingTime = newFeedingTime;

        public void MarkAsCompleted() => FeedingTime = DateTime.MinValue;
    }
}
