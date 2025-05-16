using Core.DTO;
using Core.Models;

namespace Core.Mappers
{
    public static class CategoryMapper
    {
        public static CategoryDTO CategoryToDTO(Category category)
        {
            return new CategoryDTO
            {
                Id = category.CategoryId,
                Name = category.Name,
                Description = category.Descripcion
            };
        }
    }
}
