namespace APITecsup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatecolumnFirstNamev3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.People", "FirstName", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "FirstName", c => c.String());
        }
    }
}
