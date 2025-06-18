namespace Hozio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class contact1phone01 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.contact1", "phoneExtension", c => c.Int(nullable: false));
            AddColumn("dbo.contact1", "phone1Extension", c => c.Int(nullable: false));
            AddColumn("dbo.contact1", "phone2Extension", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.contact1", "phone2Extension");
            DropColumn("dbo.contact1", "phone1Extension");
            DropColumn("dbo.contact1", "phoneExtension");
        }
    }
}
