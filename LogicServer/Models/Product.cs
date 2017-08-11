namespace LogicServer.Models
{
    /// <summary>
    /// Product model
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Gets or sets identification of the product.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets name of the product.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets product category.
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets nullable price of the category.
        /// </summary>
        public decimal? Price { get; set; }
    }
}