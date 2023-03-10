using GameStore.Catalog.Api.Domain.Models;

namespace GameStore.Catalog.Api.Domain.Interfaces.Actions
{
    public interface IGet<T> where T : Entity
    {
        Task<T> Get(Guid id);
    }
}
