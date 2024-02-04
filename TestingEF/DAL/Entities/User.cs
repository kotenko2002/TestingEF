namespace TestingEF.DAL.Entities
{
    public class User : BaseEntity
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }

        //public ICollection<WorkDay> WorkDays { get; set; }
    }
}
