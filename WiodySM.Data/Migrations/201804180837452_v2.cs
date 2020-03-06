namespace WiodySM.Data.Configuration
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Item", "ITEM_ITEMASSM_ID", "dbo.Item");
            DropForeignKey("dbo.Item", "ITEM_ITEMDEASSM_ID", "dbo.Item");
            DropForeignKey("dbo.Item", "ITEM_ITEMDEASSMDE_ID", "dbo.Item");
            DropIndex("dbo.Item", new[] { "ITEM_ITEMASSM_ID" });
            DropIndex("dbo.Item", new[] { "ITEM_ITEMDEASSM_ID" });
            DropIndex("dbo.Item", new[] { "ITEM_ITEMDEASSMDE_ID" });
            AddColumn("dbo.Item", "ITEM_ASSM_CODE", c => c.String());
            AddColumn("dbo.Item", "ITEM_DEASSM_CODE", c => c.String());
            AddColumn("dbo.Item", "ITEM_DEASSMDE_CODE", c => c.String());
            DropColumn("dbo.Item", "ITEM_ITEMASSM_ID");
            DropColumn("dbo.Item", "ITEM_ITEMDEASSM_ID");
            DropColumn("dbo.Item", "ITEM_ITEMDEASSMDE_ID");
            DropColumn("dbo.Item", "ITEM_SERIALNUMBER");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Item", "ITEM_SERIALNUMBER", c => c.String());
            AddColumn("dbo.Item", "ITEM_ITEMDEASSMDE_ID", c => c.Int());
            AddColumn("dbo.Item", "ITEM_ITEMDEASSM_ID", c => c.Int());
            AddColumn("dbo.Item", "ITEM_ITEMASSM_ID", c => c.Int());
            DropColumn("dbo.Item", "ITEM_DEASSMDE_CODE");
            DropColumn("dbo.Item", "ITEM_DEASSM_CODE");
            DropColumn("dbo.Item", "ITEM_ASSM_CODE");
            CreateIndex("dbo.Item", "ITEM_ITEMDEASSMDE_ID");
            CreateIndex("dbo.Item", "ITEM_ITEMDEASSM_ID");
            CreateIndex("dbo.Item", "ITEM_ITEMASSM_ID");
            AddForeignKey("dbo.Item", "ITEM_ITEMDEASSMDE_ID", "dbo.Item", "ID");
            AddForeignKey("dbo.Item", "ITEM_ITEMDEASSM_ID", "dbo.Item", "ID");
            AddForeignKey("dbo.Item", "ITEM_ITEMASSM_ID", "dbo.Item", "ID");
        }
    }
}
