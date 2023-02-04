using GameStore.Catalog.Api.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GameStore.Catalog.Api.Infrastructure.Mappings
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            var converter = new EnumToStringConverter<Category>();

            builder.ToTable(nameof(Product));

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(p => p.About)
                .HasMaxLength(1000)
                .IsRequired();
            builder.Property(p => p.Category)
                .HasConversion(converter)
                .IsRequired();
            builder.Property(p => p.Price)
                .IsRequired();
        }
    }
}
