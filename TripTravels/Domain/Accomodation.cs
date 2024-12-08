namespace TripTravels.Domain
{
    public class Accomodation : BaseDomainModel
    {

        public int TripId { get; set; } //FK
        public string? Address { get; set; }

        public DateTime? CheckInDate { get; set; }

        public DateTime? CheckOutDate { get; set; }

        public decimal Cost { get; set; }



    }
}
