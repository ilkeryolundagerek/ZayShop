namespace ZayShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class likes_stars : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CartItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        CartId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Carts", t => t.CartId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.CartId);
            
            CreateTable(
                "dbo.Carts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        Status = c.String(),
                        Title = c.String(),
                        Detail = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        Active = c.Boolean(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Firstname = c.String(),
                        Middlename = c.String(),
                        Lastname = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        Phone = c.String(),
                        Title = c.String(),
                        Detail = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        Active = c.Boolean(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Likes",
                c => new
                    {
                        CustomerId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.CustomerId, t.ProductId })
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.CustomerId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Stars",
                c => new
                    {
                        CustomerId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        StarCount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.CustomerId, t.ProductId })
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.CustomerId)
                .Index(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CartItems", "ProductId", "dbo.Products");
            DropForeignKey("dbo.CartItems", "CartId", "dbo.Carts");
            DropForeignKey("dbo.Carts", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Stars", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Stars", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Likes", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Likes", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Stars", new[] { "ProductId" });
            DropIndex("dbo.Stars", new[] { "CustomerId" });
            DropIndex("dbo.Likes", new[] { "ProductId" });
            DropIndex("dbo.Likes", new[] { "CustomerId" });
            DropIndex("dbo.Carts", new[] { "CustomerId" });
            DropIndex("dbo.CartItems", new[] { "CartId" });
            DropIndex("dbo.CartItems", new[] { "ProductId" });
            DropTable("dbo.Stars");
            DropTable("dbo.Likes");
            DropTable("dbo.Customers");
            DropTable("dbo.Carts");
            DropTable("dbo.CartItems");
        }
    }
}
