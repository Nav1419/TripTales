using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TripTravels.Domain;

namespace TripTravels.Data
{
    public class TripTravelsContext(DbContextOptions<TripTravelsContext> options) : DbContext(options)
    {
        public DbSet<TripTravels.Domain.Activity> Activity { get; set; } = default!;
        public DbSet<TripTravels.Domain.Accomodation> Accomodation { get; set; } = default!;
        public DbSet<TripTravels.Domain.Destination> Destination { get; set; } = default!;
        public DbSet<TripTravels.Domain.Itinerary> Itinerary { get; set; } = default!;
        public DbSet<TripTravels.Domain.Review> Review { get; set; } = default!;
        public DbSet<TripTravels.Domain.Trip> Trip { get; set; } = default!;
        public DbSet<TripTravels.Domain.User> User { get; set; } = default!;
    }
}
