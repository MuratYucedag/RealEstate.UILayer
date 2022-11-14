namespace RealEstate.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_new_table_2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        ContactID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Subject = c.String(),
                        Mail = c.String(),
                        Description = c.String(),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ContactID);
            
            CreateTable(
                "dbo.Features",
                c => new
                    {
                        FeatureID = c.Int(nullable: false, identity: true),
                        Title1 = c.String(),
                        Title2 = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.FeatureID);
            
            CreateTable(
                "dbo.FeatureServices",
                c => new
                    {
                        FeatureServiceID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        ImageIcon = c.String(),
                    })
                .PrimaryKey(t => t.FeatureServiceID);
            
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AddressID = c.Int(nullable: false, identity: true),
                        Address1 = c.String(),
                        Phone1 = c.String(),
                        Phone2 = c.String(),
                        Mail1 = c.String(),
                        Mail2 = c.String(),
                        MapLocation = c.String(),
                    })
                .PrimaryKey(t => t.AddressID);
            
            CreateTable(
                "dbo.SocialMedias",
                c => new
                    {
                        SocialMediaID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Url = c.String(),
                    })
                .PrimaryKey(t => t.SocialMediaID);
            
            CreateTable(
                "dbo.Subscribes",
                c => new
                    {
                        SubscribeID = c.Int(nullable: false, identity: true),
                        Mail = c.String(),
                    })
                .PrimaryKey(t => t.SubscribeID);
            
            CreateTable(
                "dbo.Testimonials",
                c => new
                    {
                        TestimonialID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Job = c.String(),
                        Title = c.String(),
                        Description = c.String(),
                        Image = c.String(),
                    })
                .PrimaryKey(t => t.TestimonialID);
            
            DropTable("dbo.Products");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        ProductType = c.String(),
                        ProductPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ProductTitle = c.String(),
                        ProductSize = c.String(),
                    })
                .PrimaryKey(t => t.ProductID);
            
            DropTable("dbo.Testimonials");
            DropTable("dbo.Subscribes");
            DropTable("dbo.SocialMedias");
            DropTable("dbo.Addresses");
            DropTable("dbo.FeatureServices");
            DropTable("dbo.Features");
            DropTable("dbo.Contacts");
        }
    }
}
