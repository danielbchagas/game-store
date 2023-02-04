using GameStore.Customer.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GameStore.Customer.Infrastructure.Mappings
{
    public class AddressMap : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable(nameof(Address));

            builder.HasKey(a => a.Id);

            builder.Property(a => a.FirstLine)
                .IsRequired();
            builder.Property(a => a.SecondLine)
                .IsRequired();
            builder.Property(a => a.ZipCode)
                .IsRequired();

            builder.HasOne(a => a.Person).WithOne(p => p.Address).HasForeignKey<Person>(p => p.Id);
        }
    }
}
