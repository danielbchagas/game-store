using GameStore.Catalog.Api.Domain.Interfaces.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace GameStore.Catalog.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _repository;

        public ProductsController(IProductRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _repository.Get();
            return Ok(result);
        }

        [HttpGet("{name}")]
        public async Task<IActionResult> Get(string name)
        {
            var result = await _repository.Get(p => p.Name == name);
            return Ok(result);
        }

        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var result = await _repository.Get(id);
            return Ok(result);
        }
    }
}
