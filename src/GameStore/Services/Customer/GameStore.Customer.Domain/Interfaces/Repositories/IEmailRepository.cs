using GameStore.Customer.Domain.Interfaces.Actions;
using GameStore.Customer.Domain.Models;

namespace GameStore.Customer.Domain.Interfaces.Repositories
{
    public interface IEmailRepository : IUpdate<Email>
    {
    }
}
