using Core.DTO;
using Methods.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace PortafolioStore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly CategoryRepository _categoryRepository;

        public ProductController(CategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository ?? throw new ArgumentNullException(nameof(categoryRepository));
        }

        [HttpPost("")]
        public ActionResult Add([FromBody] CategoryDTO categoryDTO)
        {
            _categoryRepository.Add(categoryDTO);
            return Ok(); // Retorna 200 OK sin contenido
        }

        [HttpGet("/{id}")]
        public ActionResult<CategoryDTO> Get(int id)
        {
            var result = _categoryRepository.Get(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpGet("")]
        public ActionResult<List<CategoryDTO>> GetList()
        {
            var result = _categoryRepository.GetList();
            return Ok(result); // Retorna 200 OK con la lista
        }
    }
}
