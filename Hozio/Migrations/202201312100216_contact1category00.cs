namespace Hozio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class contact1category00 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.contact1", "category", c => c.String());
            DropColumn("dbo.contact1", "dategory");
        }
        
        public override void Down()
        {
            AddColumn("dbo.contact1", "dategory", c => c.String());
            DropColumn("dbo.contact1", "category");
        }
    }
}
