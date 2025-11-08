using Microsoft.EntityFrameworkCore;
using MVCTask.DAL.Configrations;
using Wasalnyy.DAL.Entities;

namespace Wasalnyy.DAL.Database
{
    public class WasalnyyDbContext: IdentityDbContext<User>
    {
        public WasalnyyDbContext(DbContextOptions<WasalnyyDbContext> options) : base(options)
        {
        }

		protected override void OnModelCreating(ModelBuilder builder)
		{
            builder.ApplyConfiguration(new ReviewConfig());
            builder.ApplyConfiguration(new TripConfig());
            base.OnModelCreating(builder);
        }

        public DbSet<User> Users {  get; set; }
        public DbSet<Rider> Riders {  get; set; }
        public DbSet<Driver> Drivers {  get; set; }
        public DbSet<Vehicle> Vehicles {  get; set; }
        public DbSet<Review> Reviews {  get; set; }
        public DbSet<Zone> Zones {  get; set; }
        public DbSet<Trip> Trips{  get; set; }


    }
}
