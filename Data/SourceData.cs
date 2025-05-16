using Core.DTO;

namespace Data
{
    public class SourceData
    {
        public static List<CategoryDTO> Categories { get; set; } = new List<CategoryDTO>
        {
            new CategoryDTO { Id = 1, Name = "Prendas", Description = "Ropa en el departamento" },
            new CategoryDTO { Id = 2, Name = "Zapatos", Description = "Calzado para todo tipo" }
        };

        public static List<ProductDTO> Products { get; set; } = new List<ProductDTO>
        {
            new ProductDTO { Id = 1, Name = "Camisa", Description = "Camisa para caballeros", CategoryId = 1 }
        };
    }
}
