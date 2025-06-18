namespace Hozio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class contact1phoneNote00 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.contact1", "phoneNote", c => c.String());
            AddColumn("dbo.contact1", "phone1Note", c => c.String());
            AddColumn("dbo.contact1", "phone2Note", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.contact1", "phone2Note");
            DropColumn("dbo.contact1", "phone1Note");
            DropColumn("dbo.contact1", "phoneNote");
        }
    }
}
