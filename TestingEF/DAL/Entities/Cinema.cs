namespace TestingEF.DAL.Entities
{
    public class Cinema : BaseEntity
    {
        public string Name { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }

        //public ICollection<WorkDay> WorkDays { get; set; }
    }
}
