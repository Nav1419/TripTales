using TripTravels.Domain;

namespace TripTravels.Domain
{
    public class Trip : BaseDomainModel
    {
        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string? Description { get; set; }

        public List<Itinerary> Itineraries { get; set; } = [];
        public List<Accomodation> Accomodations { get; set; }= new List<Accomodation>();


    }
}