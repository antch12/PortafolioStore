using Core.DTO;
using Data;
using Methods.Interfaces;

namespace Methods.Repositories
{
    public class CategoryRepository : IBaseInterface<CategoryDTO>
    {
        public void Add(CategoryDTO categoryDTO) 
        {
            SourceData.Categories.Add(categoryDTO);
        }

        public CategoryDTO? Get(int id)
        {
            return SourceData.Categories.FirstOrDefault(c => c.Id == id);
        }

        public List<CategoryDTO> GetList()
        {
            return SourceData.Categories.ToList();
        }
    }
}
