using TestingEF.DAL.Entities;
using TestingEF.DAL.Repositories.Base;

namespace TestingEF.DAL.Repositories.Cinemas
{
    public class CinemaRepository : BaseRepository<Cinema>, ICinemaRepository
    {
        public CinemaRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
