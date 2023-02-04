using GameStore.Catalog.Api.Domain.Models;
using System.Linq.Expressions;

namespace GameStore.Catalog.Api.Domain.Interfaces.Actions
{
    public interface IGet<T> where T : Entity
    {
        Task<IEnumerable<T>> Get();
        Task<IEnumerable<T>> Get(Expression<Func<T, bool>> expression);
        Task<T> Get(Guid id);
    }
}
