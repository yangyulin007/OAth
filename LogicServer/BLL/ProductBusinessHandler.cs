namespace LogicServer.BLL
{
    using System.Collections.Generic;
    using Interface;
    using Models;

    /// <summary>
    /// The business layer for product service.
    /// </summary>
    public class ProductBusinessHandler : IProductBusinessHandler
    {
        private const string Slogen = "Hello world!";
        private static readonly Dictionary<string, string> TESTDIC = new Dictionary<string, string>();
        private IProductRepository productRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductBusinessHandler"/> class.
        /// Constructer which will get instance of IProductRepository from container.
        /// </summary>
        /// <param name="theRepository">Instance of interface IProductRepository</param>
        public ProductBusinessHandler(IProductRepository theRepository)
        {
            productRepository = theRepository;
        }

        /// <inheritdoc/>
        public void AddProduct(Product newProduct)
        {
            if (newProduct != null)
            {
                productRepository.AddProduct(newProduct.Id, newProduct.Name, newProduct.Category, newProduct.Price);
            }
        }

        /// <inheritdoc/>
        public Product GetProduct(int id)
        {
            return productRepository.GetProduct(id);
        }

        /// <inheritdoc/>
        public IEnumerable<Product> GetProducts()
        {
            return productRepository.GetProducts();
        }

        /// <inheritdoc/>
        public void UpdateProduct(int id, string name, string category, decimal? price)
        {
            productRepository.UpdateProduct(id, name, category, price);
        }

        /// <inheritdoc/>
        public void DeleteProduct(int id)
        {
            productRepository.DeleteProduct(id);
        }
    }
}