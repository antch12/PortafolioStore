using Core.DTO;
using Data;
using Methods.Interfaces;

namespace Methods.Repositories
{
    public class ProductRepository: IBaseInterface<ProductDTO>
    {
        public void Add(ProductDTO productDTO)
        {
            SourceData.Products.Add(productDTO);
        }

        public ProductDTO? Get(int id)
        {
            return SourceData.Products.FirstOrDefault(p => p.Id == id);
        }

        public List<ProductDTO> GetList()
        {
            return SourceData.Products.ToList();
        }
    }
}
