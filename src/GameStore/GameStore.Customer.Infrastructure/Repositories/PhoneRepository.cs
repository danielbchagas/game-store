using GameStore.Customer.Domain.Interfaces.Repositories;
using GameStore.Customer.Domain.Models;
using GameStore.Customer.Infrastructure.Contexts;

namespace GameStore.Customer.Infrastructure.Repositories
{
    public class PhoneRepository : IPhoneRepository
    {
        private readonly ApplicationContext _context;

        public PhoneRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task Update(Phone entity)
        {
            _context.Phones.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
