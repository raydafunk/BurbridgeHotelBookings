using BurbridgeHotelBookings.Data.Entites;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace BurbridgeHotelBookings.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<RoomCatagory> RoomCatagories { get; set; }
        public DbSet<Room> Rooms{ get; set; }
        public DbSet<Amenity> Amenities{ get; set; }
        public DbSet<RoomCatagoryAmenity> RoomCatagoryAmenities{ get; set; }
        public DbSet<Booking> Bookings    { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<RoomCatagoryAmenity>()
                .HasKey(ro => new { ro.RoomCatagoryId, ro.AmenityId });

            builder.Entity<RoomCatagory>()
                .HasMany(rt => rt.Rooms)
                .WithOne(r =>r.RoomCatagory)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
