namespace Hozio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class prehog2Ctrl01 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.hog2", "hogOld", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.hog2", "hogOld", c => c.Int(nullable: false));
        }
    }
}
