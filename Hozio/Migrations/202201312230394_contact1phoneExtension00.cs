namespace Hozio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class contact1phoneExtension00 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.contact1", "phoneExtension");
            DropColumn("dbo.contact1", "phone1Extension");
            DropColumn("dbo.contact1", "phone2Extension");
        }
        
        public override void Down()
        {
            AddColumn("dbo.contact1", "phone2Extension", c => c.Int(nullable: false));
            AddColumn("dbo.contact1", "phone1Extension", c => c.Int(nullable: false));
            AddColumn("dbo.contact1", "phoneExtension", c => c.Int(nullable: false));
        }
    }
}
