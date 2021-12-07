namespace APITecsup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InvoiceandDetailv5 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Details",
                c => new
                    {
                        DetailID = c.Int(nullable: false, identity: true),
                        Count = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        SubTotal = c.Int(nullable: false),
                        InvoiceID = c.Int(nullable: false),
                        ProductID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DetailID)
                .ForeignKey("dbo.Invoices", t => t.InvoiceID, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.InvoiceID)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        InvoiceID = c.Int(nullable: false, identity: true),
                        CreatedOn = c.DateTime(nullable: false),
                        Number = c.String(),
                        Total = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.InvoiceID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Details", "ProductID", "dbo.Products");
            DropForeignKey("dbo.Details", "InvoiceID", "dbo.Invoices");
            DropIndex("dbo.Details", new[] { "ProductID" });
            DropIndex("dbo.Details", new[] { "InvoiceID" });
            DropTable("dbo.Products");
            DropTable("dbo.Invoices");
            DropTable("dbo.Details");
        }
    }
}
