namespace WiodySM.Data.Configuration
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v18 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ItemDemandDetail", "ITEMDEMANDDETAIL_ITEM_CONFIRMATION", c => c.Boolean(nullable: false));
            AddColumn("dbo.ItemDemandMaster", "ITEMDEMANDMASTER_ITEMCONFIRMATION", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ItemDemandMaster", "ITEMDEMANDMASTER_ITEMCONFIRMATION");
            DropColumn("dbo.ItemDemandDetail", "ITEMDEMANDDETAIL_ITEM_CONFIRMATION");
        }
    }
}
