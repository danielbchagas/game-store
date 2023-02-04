using GameStore.Customer.Domain.Models;

namespace GameStore.Customer.Domain.Interfaces.Actions
{
    public interface IRemove<T> where T : Entity
    {
        Task Delete(T entity);
    }
}
