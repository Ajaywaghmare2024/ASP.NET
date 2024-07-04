using FlipKart.Models;
using FlipKart.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FlipKart.Services
{
    public class ProductService : IproductService
    {
        public void Delete(int Id)
        {
            using (var context = new EstoreCollectionContext())


            {
                var product = context.products.Find(Id);
                if (product != null)
                {
                    context.products.Remove(product);
                    context.SaveChanges();
                }
                
            }

        }

        public Product GetProductById(int id)
        {
           using (var context= new EstoreCollectionContext())
            {
                var product= context.products.Find(id);
                return product;
            }
        }

        public List<Product> GetProducts()
        {
            using (var context = new EstoreCollectionContext())
            {
                var products = from p in context.products select p;
                return products.ToList<Product>();
            }
        }

        public void Insert(Product product)
        {
           using (var context=new EstoreCollectionContext())
            {
                context.products.Add(product);
                context.SaveChanges();
            }
        }

        public void Update(Product product)
        {
           using (var context=new EstoreCollectionContext())
            {
                var theProd= context.products.Find(product.Id);
                theProd.Title= product.Title;


                theProd.Price= product.Price;
                theProd.Description= product.Description;
                theProd.ImageUrl= product.ImageUrl;
                theProd.Quantity= product.Quantity;
                context.products.Update(theProd);
                context.SaveChanges();
            }
        }
    }
}
