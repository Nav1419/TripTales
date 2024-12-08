namespace TripTravels.Domain
{
    public class Activity : BaseDomainModel
    {

        public string? TripId { get; set; }

        public string? Description { get; set; }

        public DateTime? ActivityDate { get; set; }

        public string? Location { get; set; }

        public decimal? Rate { get; set; }



    }
}
