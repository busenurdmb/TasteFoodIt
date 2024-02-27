namespace TasteFoodIt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _updatecategorywithproduct : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Products", new[] { "Category_CategoryId" });
            CreateIndex("dbo.Products", "category_CategoryId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Products", new[] { "category_CategoryId" });
            CreateIndex("dbo.Products", "Category_CategoryId");
        }
    }
}
