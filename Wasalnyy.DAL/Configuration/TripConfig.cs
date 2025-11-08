namespace Wasalnyy.DAL.Configuration
{
	public class TripConfig : IEntityTypeConfiguration<Trip>
	{
		public void Configure(EntityTypeBuilder<Trip> builder)
		{
			builder.HasOne(t => t.Driver)
					.WithMany(d => d.Trips)
					.HasForeignKey(t => t.DriverId)
					.OnDelete(DeleteBehavior.NoAction);

			builder.HasOne(t => t.Rider)
					.WithMany(r => r.Trips)
					.HasForeignKey(t => t.RiderId)
					.OnDelete(DeleteBehavior.NoAction);
		}
	}
}
