namespace TestingEF.DAL.Entities
{
    public class WorkDay : BaseEntity
    {
        public DateTime Started { get; set; }
        public DateTime? Ended { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int CinemaId { get; set; }
        public Cinema Cinema { get; set; }
    }
}
