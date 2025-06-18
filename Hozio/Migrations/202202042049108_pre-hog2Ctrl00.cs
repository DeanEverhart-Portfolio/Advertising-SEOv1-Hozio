namespace Hozio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class prehog2Ctrl00 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.hog2",
                c => new
                    {
                        hog2ID = c.Int(nullable: false, identity: true),
                        run = c.Int(nullable: false),
                        stringRun = c.String(),
                        template = c.Int(nullable: false),
                        dateTemplate = c.DateTime(precision: 7, storeType: "datetime2"),
                        location = c.String(),
                        keyword = c.Boolean(nullable: false),
                        stringKeyword = c.String(),
                        stringKeyword1 = c.String(),
                        content = c.Boolean(nullable: false),
                        content1 = c.Boolean(nullable: false),
                        dateContent = c.DateTime(precision: 7, storeType: "datetime2"),
                        dateContent1 = c.DateTime(precision: 7, storeType: "datetime2"),
                        stringContent = c.String(),
                        html = c.Boolean(nullable: false),
                        dateHtml = c.DateTime(precision: 7, storeType: "datetime2"),
                        meta = c.Boolean(nullable: false),
                        stringMeta = c.String(),
                        dateMeta = c.DateTime(precision: 7, storeType: "datetime2"),
                        seo = c.Boolean(nullable: false),
                        dateSeo = c.DateTime(precision: 7, storeType: "datetime2"),
                        plugin = c.Boolean(nullable: false),
                        datePlugin = c.DateTime(precision: 7, storeType: "datetime2"),
                        hero = c.Boolean(nullable: false),
                        hero1 = c.Boolean(nullable: false),
                        stringHero = c.String(),
                        dateHero = c.DateTime(precision: 7, storeType: "datetime2"),
                        backup = c.Boolean(nullable: false),
                        stringBackup = c.String(),
                        dateBackup = c.DateTime(precision: 7, storeType: "datetime2"),
                        buildExport = c.Boolean(nullable: false),
                        dateBuildExport = c.DateTime(precision: 7, storeType: "datetime2"),
                        stringBuildExport = c.String(),
                        hog1 = c.Boolean(nullable: false),
                        dateHog = c.DateTime(precision: 7, storeType: "datetime2"),
                        stringHog = c.String(),
                        post = c.Boolean(nullable: false),
                        stringPost = c.String(),
                        datePost = c.DateTime(precision: 7, storeType: "datetime2"),
                        site = c.Boolean(nullable: false),
                        dateSite = c.DateTime(precision: 7, storeType: "datetime2"),
                        stringSite = c.String(),
                        dev = c.Boolean(nullable: false),
                        hogOld = c.Int(nullable: false),
                        designator = c.String(),
                        type = c.String(),
                        type1 = c.String(),
                        category = c.String(),
                        category1 = c.String(),
                        tier = c.Int(),
                        boolTier = c.Boolean(),
                        stringTier = c.String(),
                        rank = c.Int(),
                        stringRank = c.String(),
                        note = c.String(),
                        note1 = c.String(),
                        text = c.String(),
                        text1 = c.String(),
                        sort = c.String(),
                        sort1 = c.String(),
                        tag = c.String(),
                        tag1 = c.String(),
                        label = c.String(),
                        label1 = c.String(),
                        boolFlag = c.Boolean(),
                        flag = c.String(),
                        boolFlag1 = c.Boolean(),
                        flag1 = c.String(),
                        select = c.Boolean(),
                        select1 = c.Boolean(),
                        start = c.DateTime(precision: 7, storeType: "datetime2"),
                        end = c.Boolean(),
                        dateEnd = c.DateTime(precision: 7, storeType: "datetime2"),
                        inactive = c.Boolean(),
                        dateInactive = c.DateTime(precision: 7, storeType: "datetime2"),
                        hold = c.Boolean(),
                        dateHold = c.DateTime(precision: 7, storeType: "datetime2"),
                        recordCreated = c.DateTime(precision: 7, storeType: "datetime2"),
                        recordInactive = c.Boolean(),
                        dateRecordInactive = c.DateTime(precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.hog2ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.hog2");
        }
    }
}
