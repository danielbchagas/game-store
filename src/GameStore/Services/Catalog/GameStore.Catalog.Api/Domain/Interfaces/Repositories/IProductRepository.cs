using GameStore.Catalog.Api.Domain.Interfaces.Actions;
using GameStore.Catalog.Api.Domain.Models;

namespace GameStore.Catalog.Api.Domain.Interfaces.Repositories
{
    public interface IProductRepository : IGet<Product>, IGetAll<Product>, IGetAllFilter<Product>
    {
    }
}
