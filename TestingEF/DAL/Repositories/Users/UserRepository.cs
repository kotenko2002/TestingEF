using Microsoft.EntityFrameworkCore;
using TestingEF.DAL.Entities;
using TestingEF.DAL.Repositories.Base;

namespace TestingEF.DAL.Repositories.Users
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<User> FindFullAsync(int id)
        {
            return await Sourse
                .Include(x => x.WorkDays)
                .FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
