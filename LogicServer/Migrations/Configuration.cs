namespace LogicServer.Migrations
{
    using System.Data.Entity.Migrations;

    /// <summary>
    /// Entity Framework migraiton configuration type.
    /// </summary>
    internal sealed class Configuration : DbMigrationsConfiguration<Models.ProductDbContext>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Configuration"/> class.
        /// </summary>
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        /// <inheritdoc/>
        protected override void Seed(Models.ProductDbContext context)
        {
            // This method will be called after migrating to the latest version.

            // You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
        }
    }
}
