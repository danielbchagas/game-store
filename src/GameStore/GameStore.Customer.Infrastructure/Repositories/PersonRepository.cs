using GameStore.Customer.Domain.Interfaces.Repositories;
using GameStore.Customer.Domain.Models;
using GameStore.Customer.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace GameStore.Customer.Infrastructure.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly ApplicationContext _context;

        public PersonRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task Create(Person entity)
        {
            await _context.Persons.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Person entity)
        {
            _context.Persons.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Person>> Get()
        {
            return await _context.Persons
                .Include(p => p.Document).AsNoTracking()
                .Include(p => p.Email).AsNoTracking()
                .Include(p => p.Phone).AsNoTracking()
                .ToListAsync();
        }

        public async Task<IEnumerable<Person>> Get(Expression<Func<Person, bool>> expression)
        {
            return await _context.Persons
                .Where(expression)
                .Include(p => p.Document).AsNoTracking()
                .Include(p => p.Email).AsNoTracking()
                .Include(p => p.Phone).AsNoTracking()
                .ToListAsync();
        }

        public async Task<Person> Get(Guid id)
        {
            return await _context.Persons
                .Include(p => p.Document).AsNoTracking()
                .Include(p => p.Email).AsNoTracking()
                .Include(p => p.Phone).AsNoTracking()
                .FirstAsync(p => p.Id == id);
        }

        public async Task Update(Person entity)
        {
            _context.Persons.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
