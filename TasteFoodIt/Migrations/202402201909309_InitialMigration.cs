namespace TasteFoodIt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Abouts",
                c => new
                    {
                        AboutID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.AboutID);
            
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AddressId = c.Int(nullable: false, identity: true),
                        Phone = c.String(),
                        Email = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.AddressId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.Chefs",
                c => new
                    {
                        ChefId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        ImageUrl = c.String(),
                        Title = c.String(),
                        NameSurname = c.String(),
                    })
                .PrimaryKey(t => t.ChefId);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        ContactId = c.Int(nullable: false, identity: true),
                        NameSurname = c.String(),
                        Email = c.String(),
                        Subject = c.String(),
                        Message = c.String(),
                        SendDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ContactId);
            
            CreateTable(
                "dbo.OpenDayHours",
                c => new
                    {
                        OpenDayHourID = c.Int(nullable: false, identity: true),
                        DayName = c.String(nullable: false, maxLength: 9),
                        OpenHourRange = c.String(maxLength: 9),
                    })
                .PrimaryKey(t => t.OpenDayHourID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        Description = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ImageUrl = c.String(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        ReservationId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Time = c.String(),
                        GuestCount = c.Byte(nullable: false),
                        ReservationStatus = c.String(),
                    })
                .PrimaryKey(t => t.ReservationId);
            
            CreateTable(
                "dbo.Testimonials",
                c => new
                    {
                        TestimonialId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        ImageUrl = c.String(),
                        NameSurname = c.String(),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.TestimonialId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Testimonials");
            DropTable("dbo.Reservations");
            DropTable("dbo.Products");
            DropTable("dbo.OpenDayHours");
            DropTable("dbo.Contacts");
            DropTable("dbo.Chefs");
            DropTable("dbo.Categories");
            DropTable("dbo.Addresses");
            DropTable("dbo.Abouts");
        }
    }
}
