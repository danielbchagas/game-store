using GameStore.Customer.Domain.Interfaces.Repositories;
using GameStore.Customer.Domain.Models;
using GameStore.Customer.Infrastructure.Contexts;

namespace GameStore.Customer.Infrastructure.Repositories
{
    public class AddressRepository : IAddressRepository
    {
        private readonly ApplicationContext _context;

        public AddressRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task Update(Address entity)
        {
            _context.Addresses.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
