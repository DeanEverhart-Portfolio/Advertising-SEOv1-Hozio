namespace Hozio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class postahrefCtrl00 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ahref",
                c => new
                    {
                        ahrefID = c.Int(nullable: false, identity: true),
                        domain = c.String(),
                        date = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        value = c.Int(nullable: false),
                        stringValue = c.String(),
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
                .PrimaryKey(t => t.ahrefID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ahref");
        }
    }
}
