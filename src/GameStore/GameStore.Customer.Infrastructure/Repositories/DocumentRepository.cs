using GameStore.Customer.Domain.Interfaces.Repositories;
using GameStore.Customer.Domain.Models;
using GameStore.Customer.Infrastructure.Contexts;

namespace GameStore.Customer.Infrastructure.Repositories
{
    public class DocumentRepository : IDocumentRepository
    {
        private readonly ApplicationContext _context;

        public DocumentRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task Update(Document entity)
        {
            _context.Documents.Update(entity);
            await _context.AddRangeAsync();
        }
    }
}
