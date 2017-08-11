namespace LogicServer.Interface
{
    using System.Collections.Generic;
    using Models;

    /// <summary>
    /// Define interface for product repository.
    /// </summary>
    public interface IProductRepository
    {
        /// <summary>
        /// Call this method to add new product in database.
        /// </summary>
        /// <param name="id">Product Id.</param>
        /// <param name="name">Product name.</param>
        /// <param name="category">Product category.</param>
        /// <param name="price">Product price.</param>
        void AddProduct(int id, string name, string category, decimal? price);

        /// <summary>
        /// Get product from database by its id.
        /// </summary>
        /// <param name="id">Product id.</param>
        /// <returns>Target product.</returns>
        Product GetProduct(int id);

        /// <summary>
        /// Get all products from database.
        /// </summary>
        /// <returns>All product in enumerable collection.</returns>
        IEnumerable<Product> GetProducts();

        /// <summary>
        /// Update target product in database.
        /// </summary>
        /// <param name="id">Product Id.</param>
        /// <param name="name">Product name.</param>
        /// <param name="category">Proudct category.</param>
        /// <param name="price">Product price.</param>
        void UpdateProduct(int id, string name, string category, decimal? price);

        /// <summary>
        /// Delete a product from database.
        /// </summary>
        /// <param name="id">Product id.</param>
        void DeleteProduct(int id);
    }
}