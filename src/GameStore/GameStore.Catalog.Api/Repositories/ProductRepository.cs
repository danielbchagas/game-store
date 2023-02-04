using GameStore.Catalog.Contexts;
using GameStore.Catalog.Interfaces.Repositories;
using GameStore.Catalog.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace GameStore.Catalog.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationContext _context;

        public ProductRepository(ApplicationContext context)
        {
            _context= context;
        }

        public async Task<IEnumerable<Product>> Get() => await _context.Products.ToListAsync();

        public async Task<IEnumerable<Product>> Get(Expression<Func<Product, bool>> expression) => await _context.Products.Where(expression).ToListAsync();

        public async Task<Product> Get(Guid id) => await _context.Products.FindAsync(id);
    }
}
