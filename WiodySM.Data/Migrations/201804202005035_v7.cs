namespace WiodySM.Data.Configuration
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v7 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PayoffControl",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PAYOFFCONTROL_LB = c.String(),
                        PAYOFFCONTROL_PYP = c.String(),
                        PAYOFFCONTROL_SAP = c.String(),
                        PAYOFFCONTROL_ITEMNAME = c.String(),
                        PAYOFFCONTROL_UNIT = c.String(),
                        PAYOFFCONTROL_TENSIZUP = c.Double(nullable: false),
                        PAYOFFCONTROL_TENUP = c.Double(nullable: false),
                        PAYOFFCONTROL_QUANTITY = c.Double(nullable: false),
                        PAYOFFCONTROL_TOTALTENUP = c.Double(nullable: false),
                        PAYOFFCONTROL_TOTALTENSIZUP = c.Double(nullable: false),
                        PAYOFFCONTROL_PAYOFFMASTER_ID = c.Int(nullable: false),
                        CREATED_DATE = c.String(),
                        CREATED_USER_ID = c.Int(nullable: false),
                        CREATED_USER_IP = c.String(),
                        ISACTIVE = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.PayoffMaster", t => t.PAYOFFCONTROL_PAYOFFMASTER_ID)
                .Index(t => t.PAYOFFCONTROL_PAYOFFMASTER_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PayoffControl", "PAYOFFCONTROL_PAYOFFMASTER_ID", "dbo.PayoffMaster");
            DropIndex("dbo.PayoffControl", new[] { "PAYOFFCONTROL_PAYOFFMASTER_ID" });
            DropTable("dbo.PayoffControl");
        }
    }
}
