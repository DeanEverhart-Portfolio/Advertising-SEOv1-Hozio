namespace Hozio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class preadminCtrl00 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.admin",
                c => new
                    {
                        adminID = c.Int(nullable: false, identity: true),
                        column01 = c.String(),
                        column02 = c.String(),
                        column03 = c.String(),
                        column04 = c.String(),
                        column05 = c.String(),
                        column06 = c.String(),
                        column07 = c.String(),
                        column08 = c.String(),
                        column09 = c.String(),
                        column10 = c.String(),
                    })
                .PrimaryKey(t => t.adminID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.admin");
        }
    }
}
