namespace WiodySM.Data.Configuration
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v5 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PayoffMaster",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PAYOFFMASTER_PROJECT_ID = c.Int(nullable: false),
                        PAYOFFMASTER_PAYOFFDEFAULT_ID = c.Int(nullable: false),
                        PAYOFFMASTER_PARAMETERCODE = c.Double(nullable: false),
                        CREATED_DATE = c.String(),
                        CREATED_USER_ID = c.Int(nullable: false),
                        CREATED_USER_IP = c.String(),
                        ISACTIVE = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.PayoffDefault", t => t.PAYOFFMASTER_PAYOFFDEFAULT_ID)
                .ForeignKey("dbo.Project", t => t.PAYOFFMASTER_PROJECT_ID)
                .Index(t => t.PAYOFFMASTER_PROJECT_ID)
                .Index(t => t.PAYOFFMASTER_PAYOFFDEFAULT_ID);
            
            CreateTable(
                "dbo.PayoffDefault",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PAYOFFDEFAULT_DEF1 = c.String(),
                        PAYOFFDEFAULT_DEF2 = c.String(),
                        PAYOFFDEFAULT_DEF3 = c.String(),
                        PAYOFFDEFAULT_DEF4 = c.String(),
                        PAYOFFDEFAULT_DEF5 = c.String(),
                        PAYOFFDEFAULT_DEF6 = c.String(),
                        PAYOFFDEFAULT_DEF7 = c.String(),
                        PAYOFFDEFAULT_DEF8 = c.String(),
                        PAYOFFDEFAULT_DEF9 = c.String(),
                        PAYOFFDEFAULT_DEF10 = c.String(),
                        PAYOFFDEFAULT_DEF11 = c.String(),
                        PAYOFFDEFAULT_DEF12 = c.String(),
                        PAYOFFDEFAULT_DEF13 = c.String(),
                        PAYOFFDEFAULT_DEF14 = c.String(),
                        PAYOFFDEFAULT_DEF15 = c.String(),
                        PAYOFFDEFAULT_DEF16 = c.String(),
                        PAYOFFDEFAULT_DEF17 = c.String(),
                        PAYOFFDEFAULT_DEF18 = c.String(),
                        PAYOFFDEFAULT_DEF19 = c.String(),
                        PAYOFFDEFAULT_DEF20 = c.String(),
                        CREATED_DATE = c.String(),
                        CREATED_USER_ID = c.Int(nullable: false),
                        CREATED_USER_IP = c.String(),
                        ISACTIVE = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PayoffDetail",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PAYOFFDETAIL_ITEMTYPE_ID = c.Int(nullable: false),
                        PAYOFFDETAIL_ITEM_ID = c.Int(nullable: false),
                        PAYOFFDETAIL_UNITPRICE = c.Double(nullable: false),
                        PAYOFFDETAIL_INCLUDEPRICE = c.Double(nullable: false),
                        CREATED_DATE = c.String(),
                        CREATED_USER_ID = c.Int(nullable: false),
                        CREATED_USER_IP = c.String(),
                        ISACTIVE = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Item", t => t.PAYOFFDETAIL_ITEM_ID)
                .ForeignKey("dbo.ParameterDetail", t => t.PAYOFFDETAIL_ITEMTYPE_ID)
                .Index(t => t.PAYOFFDETAIL_ITEMTYPE_ID)
                .Index(t => t.PAYOFFDETAIL_ITEM_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PayoffDetail", "PAYOFFDETAIL_ITEMTYPE_ID", "dbo.ParameterDetail");
            DropForeignKey("dbo.PayoffDetail", "PAYOFFDETAIL_ITEM_ID", "dbo.Item");
            DropForeignKey("dbo.PayoffMaster", "PAYOFFMASTER_PROJECT_ID", "dbo.Project");
            DropForeignKey("dbo.PayoffMaster", "PAYOFFMASTER_PAYOFFDEFAULT_ID", "dbo.PayoffDefault");
            DropIndex("dbo.PayoffDetail", new[] { "PAYOFFDETAIL_ITEM_ID" });
            DropIndex("dbo.PayoffDetail", new[] { "PAYOFFDETAIL_ITEMTYPE_ID" });
            DropIndex("dbo.PayoffMaster", new[] { "PAYOFFMASTER_PAYOFFDEFAULT_ID" });
            DropIndex("dbo.PayoffMaster", new[] { "PAYOFFMASTER_PROJECT_ID" });
            DropTable("dbo.PayoffDetail");
            DropTable("dbo.PayoffDefault");
            DropTable("dbo.PayoffMaster");
        }
    }
}
