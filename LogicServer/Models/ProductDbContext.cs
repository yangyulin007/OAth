namespace LogicServer.Models
{
    using System.Data.Entity;

    /// <summary>
    /// DbContext type for product.
    /// </summary>
    public partial class ProductDbContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductDbContext"/> class.
        /// </summary>
        public ProductDbContext()
            : base("MarketDbContext")
        {
            Database.SetInitializer<ProductDbContext>(null);
        }

        /// <summary>
        /// Gets or sets dataset of products.
        /// </summary>
        public DbSet<Product> Products { get; set; }

        /// <inheritdoc/>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("APIDEMOUSER");   // Schema is the user name
        }
    }
}