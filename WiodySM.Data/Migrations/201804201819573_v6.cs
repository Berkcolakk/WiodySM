namespace WiodySM.Data.Configuration
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v6 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PayoffMaster", "PAYOFFMASTER_PAYOFFDEFAULT_ID", "dbo.PayoffDefault");
            DropIndex("dbo.PayoffMaster", new[] { "PAYOFFMASTER_PAYOFFDEFAULT_ID" });
            AddColumn("dbo.PayoffDefault", "PAYOFFDEFAULT_PAYOFFMASTER_ID", c => c.Int(nullable: false));
            CreateIndex("dbo.PayoffDefault", "PAYOFFDEFAULT_PAYOFFMASTER_ID");
            AddForeignKey("dbo.PayoffDefault", "PAYOFFDEFAULT_PAYOFFMASTER_ID", "dbo.PayoffMaster", "ID");
            DropColumn("dbo.PayoffMaster", "PAYOFFMASTER_PAYOFFDEFAULT_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PayoffMaster", "PAYOFFMASTER_PAYOFFDEFAULT_ID", c => c.Int(nullable: false));
            DropForeignKey("dbo.PayoffDefault", "PAYOFFDEFAULT_PAYOFFMASTER_ID", "dbo.PayoffMaster");
            DropIndex("dbo.PayoffDefault", new[] { "PAYOFFDEFAULT_PAYOFFMASTER_ID" });
            DropColumn("dbo.PayoffDefault", "PAYOFFDEFAULT_PAYOFFMASTER_ID");
            CreateIndex("dbo.PayoffMaster", "PAYOFFMASTER_PAYOFFDEFAULT_ID");
            AddForeignKey("dbo.PayoffMaster", "PAYOFFMASTER_PAYOFFDEFAULT_ID", "dbo.PayoffDefault", "ID");
        }
    }
}
