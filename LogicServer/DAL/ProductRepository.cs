namespace LogicServer.DAL
{
    using System.Collections.Generic;
    using System.Linq;
    using Interface;
    using Models;

    /// <summary>
    /// Implement CRUD operation for product entity.
    /// </summary>
    public class ProductRepository : IProductRepository
    {
        /// <inheritdoc/>
        public void AddProduct(int id, string name, string category, decimal? price)
        {
            using (var context = new ProductDbContext())
            {
                var newProduct = new Product()
                {
                    Id = id,
                    Name = name,
                    Category = category,
                    Price = price ?? 0M,
                };

                context.Products.Add(newProduct);
                context.SaveChanges();
            }
        }

        /// <inheritdoc/>
        public Product GetProduct(int id)
        {
            using (var context = new ProductDbContext())
            {
                var targetProduct = context.Products.FirstOrDefault(p => p.Id == id);
                return targetProduct;
            }
        }

        /// <inheritdoc/>
        public IEnumerable<Product> GetProducts()
        {
            using (var context = new ProductDbContext())
            {
                return context.Products.ToList();
            }
        }

        /// <inheritdoc/>
        public void UpdateProduct(int id, string name, string category, decimal? price)
        {
            using (var context = new ProductDbContext())
            {
                var targetProduct = context.Products.FirstOrDefault(p => p.Id == id);

                if (targetProduct != null)
                {
                    targetProduct.Name = string.IsNullOrWhiteSpace(name) ? targetProduct.Name : name;
                    targetProduct.Category = string.IsNullOrWhiteSpace(category) ? targetProduct.Category : category;
                    targetProduct.Price = price ?? targetProduct.Price;
                    context.SaveChanges();
                }
            }
        }

        /// <inheritdoc/>
        public void DeleteProduct(int id)
        {
            using (var context = new ProductDbContext())
            {
                var targetProduct = context.Products.FirstOrDefault(p => p.Id == id);

                if (targetProduct != null)
                {
                    context.Products.Remove(targetProduct);
                    context.SaveChanges();
                }
            }
        }
    }
}