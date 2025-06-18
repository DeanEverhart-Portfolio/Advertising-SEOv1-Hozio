namespace Hozio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class contact1address00 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.contact1", "addressStreet2", c => c.String());
            AddColumn("dbo.contact1", "addressTownCity", c => c.String());
            AddColumn("dbo.contact1", "addressZipCode", c => c.String());
            DropColumn("dbo.contact1", "address2");
            DropColumn("dbo.contact1", "addressZip");
        }
        
        public override void Down()
        {
            AddColumn("dbo.contact1", "addressZip", c => c.String());
            AddColumn("dbo.contact1", "address2", c => c.String());
            DropColumn("dbo.contact1", "addressZipCode");
            DropColumn("dbo.contact1", "addressTownCity");
            DropColumn("dbo.contact1", "addressStreet2");
        }
    }
}
