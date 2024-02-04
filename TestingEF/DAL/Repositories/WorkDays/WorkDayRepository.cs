using TestingEF.DAL.Entities;
using TestingEF.DAL.Repositories.Base;

namespace TestingEF.DAL.Repositories.WorkDays
{
    public class WorkDayRepository : BaseRepository<WorkDay>, IWorkDayRepository
    {
        public WorkDayRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
