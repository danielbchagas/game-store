using GameStore.Customer.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GameStore.Customer.Infrastructure.Mappings
{
    public class PhoneMap : IEntityTypeConfiguration<Phone>
    {
        public void Configure(EntityTypeBuilder<Phone> builder)
        {
            builder.ToTable(nameof(Phone));

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Number);

            builder.HasOne(p => p.Person).WithOne(p => p.Phone).HasForeignKey<Person>(p => p.Id);
        }
    }
}
