using GameStore.Customer.Domain.Models;

namespace GameStore.Customer.Domain.Interfaces.Actions
{
    public interface IUpdate<T> where T : Entity
    {
        Task Update(T entity);
    }
}
