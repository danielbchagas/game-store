using GameStore.Customer.Domain.Interfaces.Repositories;
using GameStore.Customer.Domain.Models;
using GameStore.Customer.Infrastructure.Contexts;

namespace GameStore.Customer.Infrastructure.Repositories
{
    public class EmailRepository : IEmailRepository
    {
        private readonly ApplicationContext _context;

        public EmailRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task Update(Email entity)
        {
            _context.Emails.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
