namespace WiodySM.Data.Configuration
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V20 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Company", "CREATED_DATE2", c => c.DateTime(nullable: false));
            AddColumn("dbo.ParameterDetail", "CREATED_DATE2", c => c.DateTime(nullable: false));
            AddColumn("dbo.Project", "CREATED_DATE2", c => c.DateTime(nullable: false));
            AddColumn("dbo.Contract", "CREATED_DATE2", c => c.DateTime(nullable: false));
            AddColumn("dbo.PayoffMaster", "CREATED_DATE2", c => c.DateTime(nullable: false));
            AddColumn("dbo.PayoffControl", "CREATED_DATE2", c => c.DateTime(nullable: false));
            AddColumn("dbo.PayoffDefault", "CREATED_DATE2", c => c.DateTime(nullable: false));
            AddColumn("dbo.ProjectExplore", "CREATED_DATE2", c => c.DateTime(nullable: false));
            AddColumn("dbo.Item", "CREATED_DATE2", c => c.DateTime(nullable: false));
            AddColumn("dbo.ItemDemandDetail", "CREATED_DATE2", c => c.DateTime(nullable: false));
            AddColumn("dbo.ItemDemandMaster", "CREATED_DATE2", c => c.DateTime(nullable: false));
            AddColumn("dbo.User", "CREATED_DATE2", c => c.DateTime(nullable: false));
            AddColumn("dbo.ProjectManager", "CREATED_DATE2", c => c.DateTime(nullable: false));
            AddColumn("dbo.PayoffDetail", "CREATED_DATE2", c => c.DateTime(nullable: false));
            AddColumn("dbo.MenuRole", "CREATED_DATE2", c => c.DateTime(nullable: false));
            AddColumn("dbo.StockDetail", "CREATED_DATE2", c => c.DateTime(nullable: false));
            AddColumn("dbo.StockMaster", "CREATED_DATE2", c => c.DateTime(nullable: false));
            AddColumn("dbo.UserRole", "CREATED_DATE2", c => c.DateTime(nullable: false));
            AddColumn("dbo.ParameterMaster", "CREATED_DATE2", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ParameterMaster", "CREATED_DATE2");
            DropColumn("dbo.UserRole", "CREATED_DATE2");
            DropColumn("dbo.StockMaster", "CREATED_DATE2");
            DropColumn("dbo.StockDetail", "CREATED_DATE2");
            DropColumn("dbo.MenuRole", "CREATED_DATE2");
            DropColumn("dbo.PayoffDetail", "CREATED_DATE2");
            DropColumn("dbo.ProjectManager", "CREATED_DATE2");
            DropColumn("dbo.User", "CREATED_DATE2");
            DropColumn("dbo.ItemDemandMaster", "CREATED_DATE2");
            DropColumn("dbo.ItemDemandDetail", "CREATED_DATE2");
            DropColumn("dbo.Item", "CREATED_DATE2");
            DropColumn("dbo.ProjectExplore", "CREATED_DATE2");
            DropColumn("dbo.PayoffDefault", "CREATED_DATE2");
            DropColumn("dbo.PayoffControl", "CREATED_DATE2");
            DropColumn("dbo.PayoffMaster", "CREATED_DATE2");
            DropColumn("dbo.Contract", "CREATED_DATE2");
            DropColumn("dbo.Project", "CREATED_DATE2");
            DropColumn("dbo.ParameterDetail", "CREATED_DATE2");
            DropColumn("dbo.Company", "CREATED_DATE2");
        }
    }
}
