using Core.DTO;

namespace PortafolioStore
{
    public class StoreViewModel
    {
        public List<CategoryDTO>? Categories { get; set; }
        public List<ProductDTO>? Products { get; set; }

        public CategoryDTO NewCategory { get; set; } = new CategoryDTO();
        public ProductDTO NewProduct { get; set; } = new ProductDTO();
    }

}
