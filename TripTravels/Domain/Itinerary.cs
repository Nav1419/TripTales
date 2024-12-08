
using System.Diagnostics;
using TripTravels.Domain;

namespace TripTravels.Domain
{
    public class Itinerary : BaseDomainModel
    {


        public int UserId { get; set; }
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int TripId { get; set; } //FK

        public List<Activity> Activities { get; set; } = [];
        //Creates a list for bothactivity and accomodation
        public List<Accomodation> Accomodations { get; set; } = [];


    }
}
