namespace TasteFoodIt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mesaj : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contacts", "Durum", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contacts", "Durum");
        }
    }
}
