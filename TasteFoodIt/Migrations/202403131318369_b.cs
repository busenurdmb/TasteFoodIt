namespace TasteFoodIt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class b : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Contacts", "IsRead");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Contacts", "IsRead", c => c.String());
        }
    }
}
