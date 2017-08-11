namespace LogicServer.Interface
{
    using System.Collections.Generic;
    using Models;

    /// <summary>
    /// Define interface IProductBusinessHandler.
    /// </summary>
    public interface IProductBusinessHandler
    {
        /// <summary>
        /// Add a new product.
        /// </summary>
        /// <param name="newProduct">Method usd to handle add new product logic.</param>
        void AddProduct(Product newProduct);

        /// <summary>
        /// Get specified product.
        /// </summary>
        /// <param name="id">Integer represent product Id.</param>
        /// <returns>Instance of Product type.</returns>
        Product GetProduct(int id);

        /// <summary>
        /// Method used to get all products.
        /// </summary>
        /// <returns>All produtcts.</returns>
        IEnumerable<Product> GetProducts();

        /// <summary>
        /// Update proudct by name, category, price.
        /// </summary>
        /// <param name="id">Product id.</param>
        /// <param name="name">Product name.</param>
        /// <param name="category">Product category.</param>
        /// <param name="price">Product price.</param>
        void UpdateProduct(int id, string name, string category, decimal? price);

        /// <summary>
        /// Delete a product by its id.
        /// </summary>
        /// <param name="id">Product id.</param>
        void DeleteProduct(int id);
    }
}