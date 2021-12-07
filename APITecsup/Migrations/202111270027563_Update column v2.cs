namespace APITecsup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updatecolumnv2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.People", "LastName", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "LastName", c => c.String());
        }
    }
}
