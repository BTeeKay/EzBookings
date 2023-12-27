using EzBookings.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EzBookings.Configuration
{
    public class DriverConfiguration : IEntityTypeConfiguration<DriverEntity>
    {
        public void Configure(EntityTypeBuilder<DriverEntity> builder)
        {
            builder.Property(d => d.FirstName)
                .IsUnicode(true)
                .HasMaxLength(36)
                .IsRequired();

            builder.Property(d => d.LastName)
                .IsUnicode(true)
                .HasMaxLength(36)
                .IsRequired();
        }
    }
}
