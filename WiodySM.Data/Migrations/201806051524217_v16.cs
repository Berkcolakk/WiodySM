namespace WiodySM.Data.Configuration
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v16 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StockDetail", "STOCKDETAIL_PRIVATEVALUE1", c => c.Double());
            AddColumn("dbo.StockDetail", "STOCKDETAIL_PRIVATEVALUE2", c => c.Double());
        }
        
        public override void Down()
        {
            DropColumn("dbo.StockDetail", "STOCKDETAIL_PRIVATEVALUE2");
            DropColumn("dbo.StockDetail", "STOCKDETAIL_PRIVATEVALUE1");
        }
    }
}
