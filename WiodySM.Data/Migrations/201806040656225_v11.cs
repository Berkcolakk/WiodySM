namespace WiodySM.Data.Configuration
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v11 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.StockMaster", new[] { "STOCKMASTER_TARGETSTORE_ID" });
            DropIndex("dbo.StockMaster", new[] { "STOCKMASTER_SOURCESTORE_ID" });
            AlterColumn("dbo.StockMaster", "STOCKMASTER_TARGETSTORE_ID", c => c.Int(nullable: false));
            AlterColumn("dbo.StockMaster", "STOCKMASTER_SOURCESTORE_ID", c => c.Int(nullable: false));
            CreateIndex("dbo.StockMaster", "STOCKMASTER_TARGETSTORE_ID");
            CreateIndex("dbo.StockMaster", "STOCKMASTER_SOURCESTORE_ID");
        }
        
        public override void Down()
        {
            DropIndex("dbo.StockMaster", new[] { "STOCKMASTER_SOURCESTORE_ID" });
            DropIndex("dbo.StockMaster", new[] { "STOCKMASTER_TARGETSTORE_ID" });
            AlterColumn("dbo.StockMaster", "STOCKMASTER_SOURCESTORE_ID", c => c.Int());
            AlterColumn("dbo.StockMaster", "STOCKMASTER_TARGETSTORE_ID", c => c.Int());
            CreateIndex("dbo.StockMaster", "STOCKMASTER_SOURCESTORE_ID");
            CreateIndex("dbo.StockMaster", "STOCKMASTER_TARGETSTORE_ID");
        }
    }
}
