namespace Hozio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class preclientCtrl00 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.client",
                c => new
                    {
                        clientID = c.Int(nullable: false, identity: true),
                        client1ID = c.Int(nullable: false),
                        hog2ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.clientID)
                .ForeignKey("dbo.client1", t => t.client1ID, cascadeDelete: true)
                .ForeignKey("dbo.hog2", t => t.hog2ID, cascadeDelete: true)
                .Index(t => t.client1ID)
                .Index(t => t.hog2ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.client", "hog2ID", "dbo.hog2");
            DropForeignKey("dbo.client", "client1ID", "dbo.client1");
            DropIndex("dbo.client", new[] { "hog2ID" });
            DropIndex("dbo.client", new[] { "client1ID" });
            DropTable("dbo.client");
        }
    }
}
