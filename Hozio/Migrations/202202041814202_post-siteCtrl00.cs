namespace Hozio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class postsiteCtrl00 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.site",
                c => new
                    {
                        siteID = c.Int(nullable: false, identity: true),
                        client1ID = c.Int(nullable: false),
                        ahrefID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.siteID)
                .ForeignKey("dbo.ahref", t => t.ahrefID, cascadeDelete: true)
                .ForeignKey("dbo.client1", t => t.client1ID, cascadeDelete: true)
                .Index(t => t.client1ID)
                .Index(t => t.ahrefID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.site", "client1ID", "dbo.client1");
            DropForeignKey("dbo.site", "ahrefID", "dbo.ahref");
            DropIndex("dbo.site", new[] { "ahrefID" });
            DropIndex("dbo.site", new[] { "client1ID" });
            DropTable("dbo.site");
        }
    }
}
