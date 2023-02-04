using GameStore.Customer.Domain.Models;

namespace GameStore.Customer.Domain.Interfaces.Actions
{
    public interface ICreate<T> where T : Entity
    {
        Task Create(T entity);
    }
}
