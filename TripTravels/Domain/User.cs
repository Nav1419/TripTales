using TripTravels.Domain;

namespace TripTravels.Domain
{
    public class User : BaseDomainModel
    {

        public string? Email { get; set; }

        public string? Password { get; set; }

        public string? ProfilePicture { get; set; }

        public List<Review> Reviews { get; set; } = new List<Review>();

        public List<Itinerary> Itineraries { get; set; } = new List<Itinerary>();

    }
}
