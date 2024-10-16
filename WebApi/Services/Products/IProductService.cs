using WebApi.Dto.Products;
using WebApi.Models;

namespace WebApi.Services.Products
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetAllProductsAsync();
        Task<ProductDto> GetProductByIdAsync(int id);
        Task<ProductDto> AddProductAsync(CreateProductDto productDto);
        Task<ProductDto> UpdateProductAsync(UpdateProductDto productDto);
        Task DeleteProductAsync(int id);
    }
}
