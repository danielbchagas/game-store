using GameStore.Customer.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GameStore.Customer.Infrastructure.Mappings
{
    public class DocumentMap : IEntityTypeConfiguration<Document>
    {
        public void Configure(EntityTypeBuilder<Document> builder)
        {
            builder.ToTable(nameof(Document));

            builder.HasKey(d => d.Id);

            builder.Property(d => d.Number)
                .IsRequired();

            builder.HasOne(d => d.Person).WithOne(p => p.Document).HasForeignKey<Person>(p => p.Id);
        }
    }
}
