
namespace TripTravels.Domain
{
    public class Destination : BaseDomainModel
    {
        public string? Description { get; set; }

        public string? City { get; set; }

        public string? Country { get; set; }

        public string? ImageUrl { get; set; }

        public List<Review>? Reviews { get; set; }

        public List<Activity>? Activities { get; set; }
    }
}
