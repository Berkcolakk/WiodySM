namespace WiodySM.Data.Configuration
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v12 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Project", "PROJECT_WORKORDERDATE", c => c.DateTime(nullable: false));
            AddColumn("dbo.Project", "PROJECT_DELIVERYDATE", c => c.DateTime(nullable: false));
            AddColumn("dbo.Project", "PROJECT_EXPLOREPRICE", c => c.Double(nullable: false));
            AddColumn("dbo.Project", "PROJECT_OWNERPRICE", c => c.Double(nullable: false));
            AddColumn("dbo.Project", "PROJECT_CONSTRUCTORPRICE", c => c.Double(nullable: false));
            AddColumn("dbo.Project", "PROJECT_DISCOUNTEDPRICE", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Project", "PROJECT_DISCOUNTEDPRICE");
            DropColumn("dbo.Project", "PROJECT_CONSTRUCTORPRICE");
            DropColumn("dbo.Project", "PROJECT_OWNERPRICE");
            DropColumn("dbo.Project", "PROJECT_EXPLOREPRICE");
            DropColumn("dbo.Project", "PROJECT_DELIVERYDATE");
            DropColumn("dbo.Project", "PROJECT_WORKORDERDATE");
        }
    }
}
