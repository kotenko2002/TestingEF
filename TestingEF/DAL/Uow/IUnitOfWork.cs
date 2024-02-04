using TestingEF.DAL.Repositories.Cinemas;
using TestingEF.DAL.Repositories.Companies;
using TestingEF.DAL.Repositories.Users;
using TestingEF.DAL.Repositories.WorkDays;

namespace TestingEF.DAL.Uow
{
    public interface IUnitOfWork
    {
        ICinemaRepository CinemaRepository { get; }
        ICompanyRepository CompanyRepository { get; }
        IUserRepository UserRepository { get; }
        IWorkDayRepository WorkDayRepository { get; }

        Task CompleteAsync();
    }
}
