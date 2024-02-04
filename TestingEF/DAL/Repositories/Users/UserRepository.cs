using TestingEF.DAL.Entities;
using TestingEF.DAL.Repositories.Base;

namespace TestingEF.DAL.Repositories.Users
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
