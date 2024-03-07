namespace TasteFoodIt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newnotificationcolums : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Notifications", "IconCirleColor", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Notifications", "IconCirleColor");
        }
    }
}
