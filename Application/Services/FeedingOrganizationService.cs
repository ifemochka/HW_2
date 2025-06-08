using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooManagement.Application.Interfaces;
using ZooManagement.Domain.Classes;

namespace ZooManagement.Application.Services
{
    public class FeedingOrganizationService
    {
        private readonly IFeedingScheduleRepository _feedingScheduleRepository;

        public FeedingOrganizationService(IFeedingScheduleRepository feedingScheduleRepository)
        {
            _feedingScheduleRepository = feedingScheduleRepository;
        }

        public void AddFeedingSchedule(FeedingSchedule schedule) => _feedingScheduleRepository.Add(schedule);

        public IEnumerable<FeedingSchedule> GetAllSchedules() => _feedingScheduleRepository.GetAll();
    }
}
