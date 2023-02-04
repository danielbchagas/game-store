using GameStore.Catalog.Api;
using GameStore.Catalog.Models;
using Microsoft.EntityFrameworkCore;
using System.Resources;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace GameStore.Catalog.Contexts
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base (options) { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationContext).Assembly);

            modelBuilder.HasPostgresEnum<Category>();

            Seed(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        private void Seed(ModelBuilder modelBuilder)
        {
            ResourceManager rm = new ResourceManager(typeof(ProductResource));

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = Guid.NewGuid(),
                Name = "Need For Speed Unbound",
                About = rm.GetString("Need For Speed Unbound - About") ?? string.Empty,
                Category = Category.Action,
                Price = 250,
                Image = rm.GetString("Need For Speed Unbound - Image") ?? string.Empty,
            }, new Product
            {
                Id = Guid.NewGuid(),
                Name = "Need For Speed Most Wanted",
                About = rm.GetString("Need For Speed Most Wanted - About") ?? string.Empty,
                Category = Category.Action,
                Price = 80,
                Image = rm.GetString("Need For Speed Most Wanted - Image") ?? string.Empty,
            }, new Product
            {
                Id = Guid.NewGuid(),
                Name = "Need For Speed Rivals",
                About = rm.GetString("Need For Speed Rivals - About") ?? string.Empty,
                Category = Category.Action,
                Price = 100,
                Image = rm.GetString("Need For Speed Rivals - Image") ?? string.Empty,
            }, new Product
            {
                Id = Guid.NewGuid(),
                Name = "Resident Evil 2 Remake",
                About = rm.GetString("Resident Evil 2 Remake - About") ?? string.Empty,
                Category = Category.Horror,
                Price = 170,
                Image = rm.GetString("Resident Evil 2 Remake - Image") ?? string.Empty,
            }, new Product
            {
                Id = Guid.NewGuid(),
                Name = "Resident Evil 3 Remake",
                About = rm.GetString("Resident Evil 3 Remake - About") ?? string.Empty,
                Category = Category.Horror,
                Price = 250,
                Image = rm.GetString("Resident Evil 3 Remake - Image") ?? string.Empty,
            }, new Product
            {
                Id = Guid.NewGuid(),
                Name = "Resident Evil 4 Remake",
                About = rm.GetString("Resident Evil 4 Remake - About") ?? string.Empty,
                Category = Category.Horror,
                Price = 235,
                Image = rm.GetString("Resident Evil 4 Remake - Image") ?? string.Empty,
            }, new Product
            {
                Id = Guid.NewGuid(),
                Name = "Grand Theft Auto V",
                About = rm.GetString("Grand Theft Auto V - About") ?? string.Empty,
                Category = Category.Action,
                Price = 210,
                Image = rm.GetString("Grand Theft Auto V - Image") ?? string.Empty,
            }, new Product
            {
                Id = Guid.NewGuid(),
                Name = "Call of Duty: Ghosts",
                About = rm.GetString("Call of Duty: Ghosts - About") ?? string.Empty,
                Category = Category.Action,
                Price = 150,
                Image = rm.GetString("Call of Duty: Ghosts - Image") ?? string.Empty,
            });
        }
    }
}
