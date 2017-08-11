namespace LogicServer.Migrations
{
    using System.Data.Entity.Migrations;

    /// <summary>
    /// Update database method for this migration.
    /// </summary>
    public partial class Initial : DbMigration
    {
        /// <summary>
        /// When update database.
        /// </summary>
        public override void Up()
        {
            CreateTable(
                "APIDEMOUSER.Products",
                c => new
                    {
                        Id = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        Name = c.String(),
                        Category = c.String(),
                        Price = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
        }

        /// <summary>
        /// When revert the database change.
        /// </summary>
        public override void Down()
        {
            DropTable("APIDEMOUSER.Products");
        }
    }
}
