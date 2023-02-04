using System.Linq.Expressions;

namespace GameStore.Catalog.Interfaces
{
    public interface IGet<Entity> where Entity : class
    {
        Task<IEnumerable<Entity>> Get();
        Task<IEnumerable<Entity>> Get(Expression<Func<Entity, bool>> expression);
        Task<Entity> Get(Guid id);
    }
}
