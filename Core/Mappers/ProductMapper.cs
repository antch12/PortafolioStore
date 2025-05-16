using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DTO;
using Core.Models;

namespace Core.Mappers
{
    public class ProductMapper
    {
        public static ProductDTO ProductToDTO(Product product)
        {
            return new ProductDTO
            {
                Id = product.ProductId,
                Name = product.Name,
                Description = product.Description,
                CategoryId = product.Fk_CategoryId
            };
        }
    }
}
