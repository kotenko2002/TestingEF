using Microsoft.AspNetCore.Mvc;
using TestingEF.DAL.Entities;
using TestingEF.DAL.Uow;

namespace TestingEF.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private readonly IUnitOfWork _uow;

        public TestController(IUnitOfWork uow)
        {
            _uow = uow;
        }

        [HttpPost]
        public async Task Add()
        {
            var company1 = new Company() { Name = "Company 1" };
            var company2 = new Company() { Name = "Company 2" };
            await _uow.CompanyRepository.AddRangeAsync(new List<Company>() { company1,company2 });

            var cinema1 = new Cinema() { Name = "Cinema 1", Company = company1 };
            var cinema2 = new Cinema() { Name = "Cinema 2", Company = company1 };
            var cinema3 = new Cinema() { Name = "Cinema 3", Company = company2 };
            var cinema4 = new Cinema() { Name = "Cinema 4", Company = company2 };
            await _uow.CinemaRepository.AddRangeAsync(new List<Cinema>() { cinema1, cinema2, cinema3, cinema4 });

            var user1 = new User() { Login = "login 1", Password = "password", Company = company1 };
            var user2 = new User() { Login = "login 2", Password = "password", Company = company1 };
            var user3 = new User() { Login = "login 3", Password = "password", Company = company2 };
            var user4 = new User() { Login = "login 4", Password = "password", Company = company2 };
            await _uow.UserRepository.AddRangeAsync(new List<User>() { user1, user2, user3, user4 });

            var workday1 = new WorkDay() { Started = DateTime.Now, User = user1, Cinema = cinema1 };
            var workday2 = new WorkDay() { Started = DateTime.Now, User = user2, Cinema = cinema1 };
            var workday3 = new WorkDay() { Started = DateTime.Now, User = user3, Cinema = cinema1 };
            var workday4 = new WorkDay() { Started = DateTime.Now, User = user4, Cinema = cinema1 };
            var workday5 = new WorkDay() { Started = DateTime.Now, User = user1, Cinema = cinema4 };
            var workday6 = new WorkDay() { Started = DateTime.Now, User = user2, Cinema = cinema3 };
            var workday7 = new WorkDay() { Started = DateTime.Now, User = user3, Cinema = cinema2 };
            var workday8 = new WorkDay() { Started = DateTime.Now, User = user4, Cinema = cinema1 };
            await _uow.WorkDayRepository.AddRangeAsync(new List<WorkDay> { workday1, workday2, workday3, workday4, workday5, workday6, workday7, workday8 });

            await _uow.CompleteAsync();
        }


        [HttpDelete("user/{id}")]
        public async Task RemoveUser(int id)
        {
            var user = await _uow.UserRepository.FindFullAsync(id);
            await _uow.WorkDayRepository.RemoveRangeAsync(user.WorkDays);
            await _uow.UserRepository.RemoveAsync(user);
            await _uow.CompleteAsync();
        }

        [HttpDelete("cinema")]
        public void RemoveCinema()
        {

        }
    }
}
