namespace Hozio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class contact1phone00 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.contact1", "phoneAreaCode", c => c.String());
            AddColumn("dbo.contact1", "phonePrefix", c => c.String());
            AddColumn("dbo.contact1", "phoneLine", c => c.String());
            AddColumn("dbo.contact1", "phoneSort", c => c.Int(nullable: false));
            AddColumn("dbo.contact1", "stringPhoneSort", c => c.String());
            AddColumn("dbo.contact1", "phone1AreaCode", c => c.String());
            AddColumn("dbo.contact1", "phone1Prefix", c => c.String());
            AddColumn("dbo.contact1", "phone1Line", c => c.String());
            AddColumn("dbo.contact1", "phone1Sort", c => c.Int(nullable: false));
            AddColumn("dbo.contact1", "stringPhone1Sort", c => c.String());
            AddColumn("dbo.contact1", "phone2AreaCode", c => c.String());
            AddColumn("dbo.contact1", "phone2Prefix", c => c.String());
            AddColumn("dbo.contact1", "phone2Line", c => c.String());
            AddColumn("dbo.contact1", "phone2Sort", c => c.Int(nullable: false));
            AddColumn("dbo.contact1", "stringPhone2Sort", c => c.String());
            DropColumn("dbo.contact1", "phone");
            DropColumn("dbo.contact1", "phone1");
            DropColumn("dbo.contact1", "phone2");
        }
        
        public override void Down()
        {
            AddColumn("dbo.contact1", "phone2", c => c.String());
            AddColumn("dbo.contact1", "phone1", c => c.String());
            AddColumn("dbo.contact1", "phone", c => c.String());
            DropColumn("dbo.contact1", "stringPhone2Sort");
            DropColumn("dbo.contact1", "phone2Sort");
            DropColumn("dbo.contact1", "phone2Line");
            DropColumn("dbo.contact1", "phone2Prefix");
            DropColumn("dbo.contact1", "phone2AreaCode");
            DropColumn("dbo.contact1", "stringPhone1Sort");
            DropColumn("dbo.contact1", "phone1Sort");
            DropColumn("dbo.contact1", "phone1Line");
            DropColumn("dbo.contact1", "phone1Prefix");
            DropColumn("dbo.contact1", "phone1AreaCode");
            DropColumn("dbo.contact1", "stringPhoneSort");
            DropColumn("dbo.contact1", "phoneSort");
            DropColumn("dbo.contact1", "phoneLine");
            DropColumn("dbo.contact1", "phonePrefix");
            DropColumn("dbo.contact1", "phoneAreaCode");
        }
    }
}
