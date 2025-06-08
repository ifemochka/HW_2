using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooManagement.Application.Interfaces;
using ZooManagement.Domain.Classes;

namespace ZooManagement.Infrastructure
{
    public class FeedingScheduleRepository : IFeedingScheduleRepository
    {
        private readonly List<FeedingSchedule> _schedules = new();

        public void Add(FeedingSchedule schedule) => _schedules.Add(schedule);

        public IEnumerable<FeedingSchedule> GetAll() => _schedules;
    }
}
