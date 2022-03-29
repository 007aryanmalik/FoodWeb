using FoodOrderingWebsite.Models;

namespace WebApplicationApi.Models
{
    public interface IProductRepository
    {

        Task Add(Product ProductId);
        Task Update(int ProductId, Product cart);
        Task Delete(int ProductId);
        Task<Product> GetProduct(int ProductId);
        Task<IEnumerable<Product>> GetProduct();
    }
}
