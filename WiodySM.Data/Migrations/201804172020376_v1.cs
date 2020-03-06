namespace WiodySM.Data.Configuration
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Company",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        COMPANY_TAXNAME = c.String(),
                        COMPANY_TAXNUMBER = c.String(),
                        COMPANY_COMPANY_NAME = c.String(),
                        COMPANY_PHONE = c.String(),
                        COMPANY_FAX = c.String(),
                        COMPANY_ADRESS = c.String(),
                        COMPANY_STORE_ID = c.Int(),
                        CREATED_DATE = c.String(),
                        CREATED_USER_ID = c.Int(nullable: false),
                        CREATED_USER_IP = c.String(),
                        ISACTIVE = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ParameterDetail", t => t.COMPANY_STORE_ID)
                .Index(t => t.COMPANY_STORE_ID);
            
            CreateTable(
                "dbo.ParameterDetail",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PARAMETERDETAIL_NAME = c.String(),
                        PARAMETERDETAIL_VALUE1 = c.String(),
                        PARAMETERDETAIL_VALUE2 = c.String(),
                        PARAMETERDETAIL_VALUE3 = c.String(),
                        PARAMETERDETAIL_MASTER_ID = c.Int(nullable: false),
                        CREATED_DATE = c.String(),
                        CREATED_USER_ID = c.Int(nullable: false),
                        CREATED_USER_IP = c.String(),
                        ISACTIVE = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ParameterMaster", t => t.PARAMETERDETAIL_MASTER_ID)
                .Index(t => t.PARAMETERDETAIL_MASTER_ID);
            
            CreateTable(
                "dbo.Project",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PROJECT_NAME = c.String(),
                        PROJECT_PYP_NO = c.String(),
                        PROJECT_DESC = c.String(),
                        PROJECT_EXPLOREDESC = c.String(),
                        PROJECT_DAY = c.Int(nullable: false),
                        PROJECT_COMPANY_ID = c.Int(nullable: false),
                        PROJECT_CONTRACT_ID = c.Int(nullable: false),
                        PROJECT_TYPE_ID = c.Int(nullable: false),
                        PROJECT_STATE_ID = c.Int(nullable: false),
                        PROJECT_EXPLORESTATE_ID = c.Int(nullable: false),
                        CREATED_DATE = c.String(),
                        CREATED_USER_ID = c.Int(nullable: false),
                        CREATED_USER_IP = c.String(),
                        ISACTIVE = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Company", t => t.PROJECT_COMPANY_ID)
                .ForeignKey("dbo.Contract", t => t.PROJECT_CONTRACT_ID)
                .ForeignKey("dbo.ParameterDetail", t => t.PROJECT_TYPE_ID)
                .ForeignKey("dbo.ParameterDetail", t => t.PROJECT_EXPLORESTATE_ID)
                .ForeignKey("dbo.ParameterDetail", t => t.PROJECT_STATE_ID)
                .Index(t => t.PROJECT_COMPANY_ID)
                .Index(t => t.PROJECT_CONTRACT_ID)
                .Index(t => t.PROJECT_TYPE_ID)
                .Index(t => t.PROJECT_STATE_ID)
                .Index(t => t.PROJECT_EXPLORESTATE_ID);
            
            CreateTable(
                "dbo.Contract",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CONTRACT_NAME = c.String(),
                        CONTRACT_TOTALPRICE = c.Double(nullable: false),
                        CONTRACT_MASTER_ID = c.Int(),
                        CONTRACT_DATE = c.DateTime(nullable: false),
                        CREATED_DATE = c.String(),
                        CREATED_USER_ID = c.Int(nullable: false),
                        CREATED_USER_IP = c.String(),
                        ISACTIVE = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Contract", t => t.CONTRACT_MASTER_ID)
                .Index(t => t.CONTRACT_MASTER_ID);
            
            CreateTable(
                "dbo.ProjectExplore",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PROJECTEXPLORE_NAME = c.String(),
                        PROJECTEXPLORE_ITEM_ID = c.Int(nullable: false),
                        PROJECTEXPLORE_PROJECT_ID = c.Int(nullable: false),
                        PROJECTEXPLORE_ITEMQUANTITY = c.Double(nullable: false),
                        PROJECTEXPLORE_ITEMASSMQUANTITY = c.Double(nullable: false),
                        PROJECTEXPLORE_ITEMDEASSMQUANTITY = c.Double(nullable: false),
                        PROJECTEXPLORE_ITEMDEASSMDEQUANTITY = c.Double(nullable: false),
                        PROJECTEXPLORE_ITEMCOUNT = c.Double(nullable: false),
                        PROJECTEXPLORE_DESC = c.String(),
                        PROJECTEXPLORE_DESC2 = c.String(),
                        CREATED_DATE = c.String(),
                        CREATED_USER_ID = c.Int(nullable: false),
                        CREATED_USER_IP = c.String(),
                        ISACTIVE = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Item", t => t.PROJECTEXPLORE_ITEM_ID)
                .ForeignKey("dbo.Project", t => t.PROJECTEXPLORE_PROJECT_ID)
                .Index(t => t.PROJECTEXPLORE_ITEM_ID)
                .Index(t => t.PROJECTEXPLORE_PROJECT_ID);
            
            CreateTable(
                "dbo.Item",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ITEM_NAME = c.String(),
                        ITEM_CODE = c.String(),
                        ITEM_DESCRIPTION = c.String(),
                        ITEM_UNIT_ID = c.Int(nullable: false),
                        ITEM_GROUP_ID = c.Int(nullable: false),
                        ITEM_ITEMASSM_ID = c.Int(),
                        ITEM_ITEMDEASSM_ID = c.Int(),
                        ITEM_ITEMDEASSMDE_ID = c.Int(),
                        ITEM_REF_CODE = c.String(),
                        ITEM_SERIALNUMBER = c.String(),
                        CREATED_DATE = c.String(),
                        CREATED_USER_ID = c.Int(nullable: false),
                        CREATED_USER_IP = c.String(),
                        ISACTIVE = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Item", t => t.ITEM_ITEMASSM_ID)
                .ForeignKey("dbo.Item", t => t.ITEM_ITEMDEASSM_ID)
                .ForeignKey("dbo.Item", t => t.ITEM_ITEMDEASSMDE_ID)
                .ForeignKey("dbo.ParameterDetail", t => t.ITEM_GROUP_ID)
                .ForeignKey("dbo.ParameterDetail", t => t.ITEM_UNIT_ID)
                .Index(t => t.ITEM_UNIT_ID)
                .Index(t => t.ITEM_GROUP_ID)
                .Index(t => t.ITEM_ITEMASSM_ID)
                .Index(t => t.ITEM_ITEMDEASSM_ID)
                .Index(t => t.ITEM_ITEMDEASSMDE_ID);
            
            CreateTable(
                "dbo.ItemDemandDetail",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ITEMDEMANDDETAIL_MASTER_ID = c.Int(nullable: false),
                        ITEMDEMANDDETAIL_ITEM_ID = c.Int(nullable: false),
                        ITEMDEMANDDETAIL_QUANTITY = c.Double(nullable: false),
                        CREATED_DATE = c.String(),
                        CREATED_USER_ID = c.Int(nullable: false),
                        CREATED_USER_IP = c.String(),
                        ISACTIVE = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Item", t => t.ITEMDEMANDDETAIL_ITEM_ID)
                .ForeignKey("dbo.ItemDemandMaster", t => t.ITEMDEMANDDETAIL_MASTER_ID)
                .Index(t => t.ITEMDEMANDDETAIL_MASTER_ID)
                .Index(t => t.ITEMDEMANDDETAIL_ITEM_ID);
            
            CreateTable(
                "dbo.ItemDemandMaster",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ITEMDEMANDMASTER_PROJECT_ID = c.Int(nullable: false),
                        ITEMDEMANDMASTER_USER_ID = c.Int(nullable: false),
                        ITEMDEMANDMASTER_DESC = c.String(),
                        ITEMDEMANDMASTER_STATE_ID = c.Int(nullable: false),
                        CREATED_DATE = c.String(),
                        CREATED_USER_ID = c.Int(nullable: false),
                        CREATED_USER_IP = c.String(),
                        ISACTIVE = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Project", t => t.ITEMDEMANDMASTER_PROJECT_ID)
                .ForeignKey("dbo.User", t => t.ITEMDEMANDMASTER_USER_ID)
                .ForeignKey("dbo.ParameterDetail", t => t.ITEMDEMANDMASTER_STATE_ID)
                .Index(t => t.ITEMDEMANDMASTER_PROJECT_ID)
                .Index(t => t.ITEMDEMANDMASTER_USER_ID)
                .Index(t => t.ITEMDEMANDMASTER_STATE_ID);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        USER_ACCESSNAME = c.String(),
                        USER_ACCESSPASSWORD = c.String(),
                        USER_NAME_SURNAME = c.String(),
                        CREATED_DATE = c.String(),
                        CREATED_USER_ID = c.Int(nullable: false),
                        CREATED_USER_IP = c.String(),
                        ISACTIVE = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ProjectManager",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PROJECTMANAGER_PROJECT_ID = c.Int(nullable: false),
                        PROJECTMANAGER_USER_ID = c.Int(nullable: false),
                        CREATED_DATE = c.String(),
                        CREATED_USER_ID = c.Int(nullable: false),
                        CREATED_USER_IP = c.String(),
                        ISACTIVE = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Project", t => t.PROJECTMANAGER_PROJECT_ID)
                .ForeignKey("dbo.User", t => t.PROJECTMANAGER_USER_ID)
                .Index(t => t.PROJECTMANAGER_PROJECT_ID)
                .Index(t => t.PROJECTMANAGER_USER_ID);
            
            CreateTable(
                "dbo.StockDetail",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        STOCKDETAIL_ITEM_ID = c.Int(nullable: false),
                        STOCKDETAIL_MASTER_ID = c.Int(nullable: false),
                        STOCKDETAIL_BARCODE_ID = c.String(),
                        STOCKDETAIL_QUANTITY = c.Double(nullable: false),
                        STOCKDETAIL_STORE_ID = c.Int(nullable: false),
                        STOCKDETAIL_RACK_ID = c.Int(nullable: false),
                        STOCKDETAIL_DESCRIPTION = c.String(),
                        STOCKDETAIL_SERIALNUMBER = c.String(),
                        STOCKDETAIL_REF_ID = c.Int(),
                        STOCKDETAIL_REF_LINK = c.String(),
                        CREATED_DATE = c.String(),
                        CREATED_USER_ID = c.Int(nullable: false),
                        CREATED_USER_IP = c.String(),
                        ISACTIVE = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Item", t => t.STOCKDETAIL_ITEM_ID)
                .ForeignKey("dbo.StockMaster", t => t.STOCKDETAIL_MASTER_ID)
                .ForeignKey("dbo.ParameterDetail", t => t.STOCKDETAIL_RACK_ID)
                .ForeignKey("dbo.ParameterDetail", t => t.STOCKDETAIL_STORE_ID)
                .Index(t => t.STOCKDETAIL_ITEM_ID)
                .Index(t => t.STOCKDETAIL_MASTER_ID)
                .Index(t => t.STOCKDETAIL_STORE_ID)
                .Index(t => t.STOCKDETAIL_RACK_ID);
            
            CreateTable(
                "dbo.StockMaster",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        STOCKMASTER_TYPE_ID = c.Int(nullable: false),
                        STOCKMASTER_STORE_ID = c.Int(nullable: false),
                        STOCKMASTER_COMPANY_ID = c.Int(nullable: false),
                        COMPANY_SUB_COMPANY_ID = c.Int(),
                        STOCKMASTER_WAYBILL_NO = c.String(),
                        STOCKMASTER_WAYBILL_DATE = c.String(),
                        STOCKMASTER_REF_ID = c.Int(),
                        STOCKMASTER_REF_LINK = c.String(),
                        CREATED_DATE = c.String(),
                        CREATED_USER_ID = c.Int(nullable: false),
                        CREATED_USER_IP = c.String(),
                        ISACTIVE = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ParameterDetail", t => t.STOCKMASTER_STORE_ID)
                .ForeignKey("dbo.ParameterDetail", t => t.STOCKMASTER_TYPE_ID)
                .ForeignKey("dbo.Company", t => t.STOCKMASTER_COMPANY_ID)
                .ForeignKey("dbo.Company", t => t.COMPANY_SUB_COMPANY_ID)
                .Index(t => t.STOCKMASTER_TYPE_ID)
                .Index(t => t.STOCKMASTER_STORE_ID)
                .Index(t => t.STOCKMASTER_COMPANY_ID)
                .Index(t => t.COMPANY_SUB_COMPANY_ID);
            
            CreateTable(
                "dbo.ParameterMaster",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PARAMETERMASTER_NAME = c.String(),
                        PARAMETERMASTER_ISEDITABLE = c.Boolean(nullable: false),
                        CREATED_DATE = c.String(),
                        CREATED_USER_ID = c.Int(nullable: false),
                        CREATED_USER_IP = c.String(),
                        ISACTIVE = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StockMaster", "COMPANY_SUB_COMPANY_ID", "dbo.Company");
            DropForeignKey("dbo.StockMaster", "STOCKMASTER_COMPANY_ID", "dbo.Company");
            DropForeignKey("dbo.StockMaster", "STOCKMASTER_TYPE_ID", "dbo.ParameterDetail");
            DropForeignKey("dbo.StockMaster", "STOCKMASTER_STORE_ID", "dbo.ParameterDetail");
            DropForeignKey("dbo.ParameterDetail", "PARAMETERDETAIL_MASTER_ID", "dbo.ParameterMaster");
            DropForeignKey("dbo.Item", "ITEM_UNIT_ID", "dbo.ParameterDetail");
            DropForeignKey("dbo.StockDetail", "STOCKDETAIL_STORE_ID", "dbo.ParameterDetail");
            DropForeignKey("dbo.Project", "PROJECT_STATE_ID", "dbo.ParameterDetail");
            DropForeignKey("dbo.StockDetail", "STOCKDETAIL_RACK_ID", "dbo.ParameterDetail");
            DropForeignKey("dbo.StockDetail", "STOCKDETAIL_MASTER_ID", "dbo.StockMaster");
            DropForeignKey("dbo.StockDetail", "STOCKDETAIL_ITEM_ID", "dbo.Item");
            DropForeignKey("dbo.ItemDemandMaster", "ITEMDEMANDMASTER_STATE_ID", "dbo.ParameterDetail");
            DropForeignKey("dbo.Item", "ITEM_GROUP_ID", "dbo.ParameterDetail");
            DropForeignKey("dbo.Project", "PROJECT_EXPLORESTATE_ID", "dbo.ParameterDetail");
            DropForeignKey("dbo.Project", "PROJECT_TYPE_ID", "dbo.ParameterDetail");
            DropForeignKey("dbo.ProjectExplore", "PROJECTEXPLORE_PROJECT_ID", "dbo.Project");
            DropForeignKey("dbo.ProjectExplore", "PROJECTEXPLORE_ITEM_ID", "dbo.Item");
            DropForeignKey("dbo.ItemDemandDetail", "ITEMDEMANDDETAIL_MASTER_ID", "dbo.ItemDemandMaster");
            DropForeignKey("dbo.ItemDemandMaster", "ITEMDEMANDMASTER_USER_ID", "dbo.User");
            DropForeignKey("dbo.ProjectManager", "PROJECTMANAGER_USER_ID", "dbo.User");
            DropForeignKey("dbo.ProjectManager", "PROJECTMANAGER_PROJECT_ID", "dbo.Project");
            DropForeignKey("dbo.ItemDemandMaster", "ITEMDEMANDMASTER_PROJECT_ID", "dbo.Project");
            DropForeignKey("dbo.ItemDemandDetail", "ITEMDEMANDDETAIL_ITEM_ID", "dbo.Item");
            DropForeignKey("dbo.Item", "ITEM_ITEMDEASSMDE_ID", "dbo.Item");
            DropForeignKey("dbo.Item", "ITEM_ITEMDEASSM_ID", "dbo.Item");
            DropForeignKey("dbo.Item", "ITEM_ITEMASSM_ID", "dbo.Item");
            DropForeignKey("dbo.Project", "PROJECT_CONTRACT_ID", "dbo.Contract");
            DropForeignKey("dbo.Contract", "CONTRACT_MASTER_ID", "dbo.Contract");
            DropForeignKey("dbo.Project", "PROJECT_COMPANY_ID", "dbo.Company");
            DropForeignKey("dbo.Company", "COMPANY_STORE_ID", "dbo.ParameterDetail");
            DropIndex("dbo.StockMaster", new[] { "COMPANY_SUB_COMPANY_ID" });
            DropIndex("dbo.StockMaster", new[] { "STOCKMASTER_COMPANY_ID" });
            DropIndex("dbo.StockMaster", new[] { "STOCKMASTER_STORE_ID" });
            DropIndex("dbo.StockMaster", new[] { "STOCKMASTER_TYPE_ID" });
            DropIndex("dbo.StockDetail", new[] { "STOCKDETAIL_RACK_ID" });
            DropIndex("dbo.StockDetail", new[] { "STOCKDETAIL_STORE_ID" });
            DropIndex("dbo.StockDetail", new[] { "STOCKDETAIL_MASTER_ID" });
            DropIndex("dbo.StockDetail", new[] { "STOCKDETAIL_ITEM_ID" });
            DropIndex("dbo.ProjectManager", new[] { "PROJECTMANAGER_USER_ID" });
            DropIndex("dbo.ProjectManager", new[] { "PROJECTMANAGER_PROJECT_ID" });
            DropIndex("dbo.ItemDemandMaster", new[] { "ITEMDEMANDMASTER_STATE_ID" });
            DropIndex("dbo.ItemDemandMaster", new[] { "ITEMDEMANDMASTER_USER_ID" });
            DropIndex("dbo.ItemDemandMaster", new[] { "ITEMDEMANDMASTER_PROJECT_ID" });
            DropIndex("dbo.ItemDemandDetail", new[] { "ITEMDEMANDDETAIL_ITEM_ID" });
            DropIndex("dbo.ItemDemandDetail", new[] { "ITEMDEMANDDETAIL_MASTER_ID" });
            DropIndex("dbo.Item", new[] { "ITEM_ITEMDEASSMDE_ID" });
            DropIndex("dbo.Item", new[] { "ITEM_ITEMDEASSM_ID" });
            DropIndex("dbo.Item", new[] { "ITEM_ITEMASSM_ID" });
            DropIndex("dbo.Item", new[] { "ITEM_GROUP_ID" });
            DropIndex("dbo.Item", new[] { "ITEM_UNIT_ID" });
            DropIndex("dbo.ProjectExplore", new[] { "PROJECTEXPLORE_PROJECT_ID" });
            DropIndex("dbo.ProjectExplore", new[] { "PROJECTEXPLORE_ITEM_ID" });
            DropIndex("dbo.Contract", new[] { "CONTRACT_MASTER_ID" });
            DropIndex("dbo.Project", new[] { "PROJECT_EXPLORESTATE_ID" });
            DropIndex("dbo.Project", new[] { "PROJECT_STATE_ID" });
            DropIndex("dbo.Project", new[] { "PROJECT_TYPE_ID" });
            DropIndex("dbo.Project", new[] { "PROJECT_CONTRACT_ID" });
            DropIndex("dbo.Project", new[] { "PROJECT_COMPANY_ID" });
            DropIndex("dbo.ParameterDetail", new[] { "PARAMETERDETAIL_MASTER_ID" });
            DropIndex("dbo.Company", new[] { "COMPANY_STORE_ID" });
            DropTable("dbo.ParameterMaster");
            DropTable("dbo.StockMaster");
            DropTable("dbo.StockDetail");
            DropTable("dbo.ProjectManager");
            DropTable("dbo.User");
            DropTable("dbo.ItemDemandMaster");
            DropTable("dbo.ItemDemandDetail");
            DropTable("dbo.Item");
            DropTable("dbo.ProjectExplore");
            DropTable("dbo.Contract");
            DropTable("dbo.Project");
            DropTable("dbo.ParameterDetail");
            DropTable("dbo.Company");
        }
    }
}
