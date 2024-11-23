using ExpressTaste.Common.Dtos;
using ExpressTaste.Common.Requests;

namespace ExpressTaste.Infraestructure.Interfaces
{
    public interface ICategoryRepository
    {
        Task<List<CategoryDto>> GetAllAsync();
        Task<CategoryDto> GetByIdAsync(int id);
        Task<CreateCategoryResponse> AddAsync(CreateCategoryRequest request);
        Task<bool> UpdateAsync(int id, UpdateCategoryRequest request);
        Task<bool> DeleteAsync(int id);
        Task<List<ProductDto>> GetCategoryProductsAsync(int categoryId);
    }
}
