namespace Hozio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HOG2ModelAdds00 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.hog2", "rerun", c => c.Boolean(nullable: false));
            AddColumn("dbo.hog2", "stringRerun", c => c.String());
            AddColumn("dbo.hog2", "content2", c => c.Boolean(nullable: false));
            AddColumn("dbo.hog2", "dateContent2", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AddColumn("dbo.hog2", "dateContent3", c => c.DateTime(precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.hog2", "dateContent3");
            DropColumn("dbo.hog2", "dateContent2");
            DropColumn("dbo.hog2", "content2");
            DropColumn("dbo.hog2", "stringRerun");
            DropColumn("dbo.hog2", "rerun");
        }
    }
}
