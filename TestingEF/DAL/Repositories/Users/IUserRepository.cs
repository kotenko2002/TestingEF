using TestingEF.DAL.Entities;
using TestingEF.DAL.Repositories.Base;

namespace TestingEF.DAL.Repositories.Users
{
    public interface IUserRepository : IBaseRepository<User>
    {
        Task<User> FindFullAsync(int id);
    }
}
