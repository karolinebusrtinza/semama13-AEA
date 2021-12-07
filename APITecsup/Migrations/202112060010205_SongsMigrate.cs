namespace APITecsup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SongsMigrate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Songs",
                c => new
                    {
                        songID = c.Int(nullable: false, identity: true),
                        songName = c.String(),
                        songSinger = c.String(),
                    })
                .PrimaryKey(t => t.songID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Songs");
        }
    }
}
