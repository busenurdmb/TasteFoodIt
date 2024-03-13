namespace TasteFoodIt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aa1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sliders",
                c => new
                    {
                        SliderID = c.Int(nullable: false, identity: true),
                        ResturantName = c.String(),
                        Title = c.String(),
                        Title2 = c.String(),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.SliderID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Sliders");
        }
    }
}
