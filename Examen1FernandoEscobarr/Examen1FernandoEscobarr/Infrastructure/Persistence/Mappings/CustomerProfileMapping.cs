using Examen1FernandoEscobarr.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Examen1FernandoEscobarr.Infrastructure.Persistence.Mappings
{
    public class CustomerProfileMapping : IEntityTypeConfiguration<CustomerProfile>
    {
        public void Configure(EntityTypeBuilder<CustomerProfile> builder)
        {
            builder.ToTable("CustomerProfile");
            builder.HasKey(cp => cp.Id);
            builder.Property(cp => cp.Address).IsRequired().HasMaxLength(200);
            builder.Property(cp => cp.PhoneNumber).IsRequired().HasMaxLength(20);

            builder.HasOne(cp => cp.Customer)
                   .WithOne(c => c.CustomerProfile)
                   .HasForeignKey<CustomerProfile>(cp => cp.CustomerId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
