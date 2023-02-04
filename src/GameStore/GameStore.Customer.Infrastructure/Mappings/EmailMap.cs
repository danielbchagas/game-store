using GameStore.Customer.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GameStore.Customer.Infrastructure.Mappings
{
    public class EmailMap : IEntityTypeConfiguration<Email>
    {
        public void Configure(EntityTypeBuilder<Email> builder)
        {
            builder.ToTable(nameof(Email));

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Address)
                .IsRequired();

            builder.HasOne(e => e.Person).WithOne(p => p.Email).HasForeignKey<Person>(p => p.Id);
        }
    }
}
