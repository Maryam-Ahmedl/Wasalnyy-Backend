using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Wasalnyy.DAL.Entities;

namespace MVCTask.DAL.Configrations
{
    public class ReviewConfig : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasIndex(x => new { x.RiderId, x.DriverId, x.TripId, x.ReviewerType })
                   .IsUnique()
                   .HasDatabaseName("IX_Review_UniqueCombination");

            builder.HasOne(r => r.Driver)
                .WithMany(d => d.Reviews)
                .HasForeignKey(r => r.DriverId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(r => r.Rider)
                .WithMany(r => r.Reviews)
                .HasForeignKey(r => r.RiderId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(r => r.Trip)
                .WithMany(t => t.Reviews)
                .HasForeignKey(r => r.TripId)
                .OnDelete(DeleteBehavior.NoAction);

            // Configure properties
            builder.Property(r => r.Id)
                .ValueGeneratedOnAdd();

            builder.Property(r => r.Comment)
                .HasMaxLength(1000);

            builder.Property(r => r.Stars)
                .HasDefaultValue(5);
        }
    }
}
