namespace TasteFoodIt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class durumm : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contacts", "IsRead", c => c.Boolean(nullable: false));
            DropColumn("dbo.Contacts", "Durum");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Contacts", "Durum", c => c.String());
            DropColumn("dbo.Contacts", "IsRead");
        }
    }
}
