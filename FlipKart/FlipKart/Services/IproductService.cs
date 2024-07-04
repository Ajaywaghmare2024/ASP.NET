using FlipKart.Models;

namespace FlipKart.Services
{
    public interface IproductService
    {
        List<Product> GetProducts();

        Product GetProductById(int id);
        void Insert(Product product);
        void Update(Product product);
        void Delete(int Id);
        
    }
}
