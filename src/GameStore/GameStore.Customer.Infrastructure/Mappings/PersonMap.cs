using GameStore.Customer.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GameStore.Customer.Infrastructure.Mappings
{
    public class PersonMap : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable(nameof(Person));

            builder.HasKey(p => p.Id);

            builder.Property(p => p.FirstName)
                .HasMaxLength(30)
                .IsRequired();
            builder.Property(p => p.LastName)
                .HasMaxLength(50)
                .IsRequired();
            
            builder.HasOne(p => p.Document).WithOne(d => d.Person).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(p => p.Email).WithOne(d => d.Person).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(p => p.Phone).WithOne(d => d.Person).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(p => p.Address).WithOne(d => d.Person).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
