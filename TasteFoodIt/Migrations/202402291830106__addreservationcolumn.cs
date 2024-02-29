namespace TasteFoodIt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _addreservationcolumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reservations", "Phone", c => c.String());
            AddColumn("dbo.Reservations", "ReservationDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reservations", "ReservationDate");
            DropColumn("dbo.Reservations", "Phone");
        }
    }
}
