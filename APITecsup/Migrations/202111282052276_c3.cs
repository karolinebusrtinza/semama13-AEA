namespace APITecsup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class c3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ClientID = c.Int(nullable: false, identity: true),
                        Invoice_InvoiceID = c.Int(),
                    })
                .PrimaryKey(t => t.ClientID)
                .ForeignKey("dbo.Invoices", t => t.Invoice_InvoiceID)
                .Index(t => t.Invoice_InvoiceID);
            
            AddColumn("dbo.Details", "IGV", c => c.Double(nullable: false));
            AddColumn("dbo.Details", "Total", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clients", "Invoice_InvoiceID", "dbo.Invoices");
            DropIndex("dbo.Clients", new[] { "Invoice_InvoiceID" });
            DropColumn("dbo.Details", "Total");
            DropColumn("dbo.Details", "IGV");
            DropTable("dbo.Clients");
        }
    }
}
