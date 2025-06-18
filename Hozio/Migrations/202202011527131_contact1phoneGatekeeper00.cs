namespace Hozio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class contact1phoneGatekeeper00 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.contact1", "phoneGatekeeper", c => c.String());
            AddColumn("dbo.contact1", "phone1Gatekeeper", c => c.String());
            AddColumn("dbo.contact1", "phone3Gatekeeper", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.contact1", "phone3Gatekeeper");
            DropColumn("dbo.contact1", "phone1Gatekeeper");
            DropColumn("dbo.contact1", "phoneGatekeeper");
        }
    }
}
