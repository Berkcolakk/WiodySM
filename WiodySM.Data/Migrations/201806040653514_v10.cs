namespace WiodySM.Data.Configuration
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v10 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.StockMaster", new[] { "STOCKMASTER_STORE_ID" });
            DropIndex("dbo.StockMaster", new[] { "STOCKMASTER_COMPANY_ID" });
            RenameColumn(table: "dbo.StockMaster", name: "STOCKMASTER_STORE_ID", newName: "STOCKMASTER_TARGETSTORE_ID");
            AddColumn("dbo.StockMaster", "STOCKMASTER_SOURCESTORE_ID", c => c.Int());
            AlterColumn("dbo.StockMaster", "STOCKMASTER_TARGETSTORE_ID", c => c.Int());
            AlterColumn("dbo.StockMaster", "STOCKMASTER_COMPANY_ID", c => c.Int());
            CreateIndex("dbo.StockMaster", "STOCKMASTER_TARGETSTORE_ID");
            CreateIndex("dbo.StockMaster", "STOCKMASTER_SOURCESTORE_ID");
            CreateIndex("dbo.StockMaster", "STOCKMASTER_COMPANY_ID");
            AddForeignKey("dbo.StockMaster", "STOCKMASTER_SOURCESTORE_ID", "dbo.ParameterDetail", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StockMaster", "STOCKMASTER_SOURCESTORE_ID", "dbo.ParameterDetail");
            DropIndex("dbo.StockMaster", new[] { "STOCKMASTER_COMPANY_ID" });
            DropIndex("dbo.StockMaster", new[] { "STOCKMASTER_SOURCESTORE_ID" });
            DropIndex("dbo.StockMaster", new[] { "STOCKMASTER_TARGETSTORE_ID" });
            AlterColumn("dbo.StockMaster", "STOCKMASTER_COMPANY_ID", c => c.Int(nullable: false));
            AlterColumn("dbo.StockMaster", "STOCKMASTER_TARGETSTORE_ID", c => c.Int(nullable: false));
            DropColumn("dbo.StockMaster", "STOCKMASTER_SOURCESTORE_ID");
            RenameColumn(table: "dbo.StockMaster", name: "STOCKMASTER_TARGETSTORE_ID", newName: "STOCKMASTER_STORE_ID");
            CreateIndex("dbo.StockMaster", "STOCKMASTER_COMPANY_ID");
            CreateIndex("dbo.StockMaster", "STOCKMASTER_STORE_ID");
        }
    }
}
