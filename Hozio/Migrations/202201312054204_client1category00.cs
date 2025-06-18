namespace Hozio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class client1category00 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.client1", "category", c => c.String());
            DropColumn("dbo.client1", "dategory");
        }
        
        public override void Down()
        {
            AddColumn("dbo.client1", "dategory", c => c.String());
            DropColumn("dbo.client1", "category");
        }
    }
}
