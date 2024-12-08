using TripTravels.Domain;

namespace TripTravels.Domain
{
    public class Review : BaseDomainModel
    {
        public int UserId { get; set; }

        public int DestinationId { get; set; }
        public int Rating { get; set; }

        public string? Comment { get; set; }

        public DateTime ReviewDate { get; set; }



    }
}