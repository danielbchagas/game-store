using GameStore.Catalog.Api.Domain.Models;
using System.Linq.Expressions;

namespace GameStore.Catalog.Api.Domain.Interfaces.Actions
{
    public interface IGetAllFilter<T> where T : Entity
    {
        Task<IEnumerable<T>> Get(Expression<Func<T, bool>> expression);
    }
}
