using GameStore.Customer.Domain.Interfaces.Actions;
using GameStore.Customer.Domain.Models;

namespace GameStore.Customer.Domain.Interfaces.Repositories
{
    public interface IPersonRepository : IGet<Person>, IUpdate<Person>, ICreate<Person>, IRemove<Person>
    {
    }
}
