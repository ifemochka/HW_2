using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooManagement.Domain.Classes;

namespace ZooManagement.Application.Interfaces
{
    public interface IFeedingScheduleRepository
    {
        void Add(FeedingSchedule schedule);
        IEnumerable<FeedingSchedule> GetAll();
    }
}
