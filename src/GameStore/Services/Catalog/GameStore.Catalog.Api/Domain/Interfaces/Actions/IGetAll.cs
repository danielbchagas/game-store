using GameStore.Catalog.Api.Domain.Models;

namespace GameStore.Catalog.Api.Domain.Interfaces.Actions
{
    public interface IGetAll<T> where T : Entity
    {
        Task<IEnumerable<T>> Get();
    }
}
