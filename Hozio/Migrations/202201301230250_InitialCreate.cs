namespace Hozio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.client1",
                c => new
                    {
                        client1ID = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false),
                        domain = c.String(),
                        domain1 = c.String(),
                        crm = c.Int(),
                        crm1 = c.Int(),
                        designator = c.String(),
                        type = c.String(),
                        type1 = c.String(),
                        dategory = c.String(),
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
                .PrimaryKey(t => t.client1ID);
            
            CreateTable(
                "dbo.contact",
                c => new
                    {
                        contactID = c.Int(nullable: false, identity: true),
                        contact1ID = c.Int(nullable: false),
                        client1ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.contactID)
                .ForeignKey("dbo.client1", t => t.client1ID, cascadeDelete: true)
                .ForeignKey("dbo.contact1", t => t.contact1ID, cascadeDelete: true)
                .Index(t => t.contact1ID)
                .Index(t => t.client1ID);
            
            CreateTable(
                "dbo.contact1",
                c => new
                    {
                        contact1ID = c.Int(nullable: false, identity: true),
                        firstName = c.String(nullable: false),
                        lastName = c.String(nullable: false),
                        middleName = c.String(),
                        aka = c.String(),
                        phone = c.String(),
                        phoneLabel = c.String(),
                        phone1 = c.String(),
                        phone1Label = c.String(),
                        phone2 = c.String(),
                        phone2Label = c.String(),
                        email = c.String(),
                        emailLabel = c.String(),
                        email1 = c.String(),
                        email1Label = c.String(),
                        email2 = c.String(),
                        email2Label = c.String(),
                        domain = c.String(),
                        domain1 = c.String(),
                        website = c.String(),
                        websiteLabel = c.String(),
                        website1 = c.String(),
                        website1Label = c.String(),
                        website2 = c.String(),
                        website2Label = c.String(),
                        addressStreetNumber = c.String(),
                        addressStreetName = c.String(),
                        addressStreetDesignator = c.String(),
                        address2 = c.String(),
                        addressState = c.String(),
                        addressZip = c.String(),
                        addressCounty = c.String(),
                        addressCountry = c.String(),
                        addressURL = c.String(),
                        doh = c.DateTime(precision: 7, storeType: "datetime2"),
                        dos = c.DateTime(precision: 7, storeType: "datetime2"),
                        designator = c.String(),
                        type = c.String(),
                        type1 = c.String(),
                        dategory = c.String(),
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
                .PrimaryKey(t => t.contact1ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.contact", "contact1ID", "dbo.contact1");
            DropForeignKey("dbo.contact", "client1ID", "dbo.client1");
            DropIndex("dbo.contact", new[] { "client1ID" });
            DropIndex("dbo.contact", new[] { "contact1ID" });
            DropTable("dbo.contact1");
            DropTable("dbo.contact");
            DropTable("dbo.client1");
        }
    }
}
