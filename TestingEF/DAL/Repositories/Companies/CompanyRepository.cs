using TestingEF.DAL.Entities;
using TestingEF.DAL.Repositories.Base;

namespace TestingEF.DAL.Repositories.Companies
{
    public class CompanyRepository : BaseRepository<Company>, ICompanyRepository
    {
        public CompanyRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
