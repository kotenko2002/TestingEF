using TestingEF.DAL.Repositories.Cinemas;
using TestingEF.DAL.Repositories.Companies;
using TestingEF.DAL.Repositories.Users;
using TestingEF.DAL.Repositories.WorkDays;

namespace TestingEF.DAL.Uow
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ApplicationDbContext _context;

        public ICinemaRepository CinemaRepository { get; }
        public ICompanyRepository CompanyRepository { get; }
        public IUserRepository UserRepository { get; }
        //public IWorkDayRepository WorkDayRepository { get; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;

            CinemaRepository = new CinemaRepository(_context);
            CompanyRepository = new CompanyRepository(_context);
            UserRepository = new UserRepository(_context);
            //WorkDayRepository = new WorkDayRepository(_context);
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
