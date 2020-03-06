namespace WiodySM.Data.Configuration
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V22 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Company", "CREATED_DATE");
            DropColumn("dbo.ParameterDetail", "CREATED_DATE");
            DropColumn("dbo.Project", "CREATED_DATE");
            DropColumn("dbo.Contract", "CREATED_DATE");
            DropColumn("dbo.PayoffMaster", "CREATED_DATE");
            DropColumn("dbo.PayoffControl", "CREATED_DATE");
            DropColumn("dbo.PayoffDefault", "CREATED_DATE");
            DropColumn("dbo.ProjectExplore", "CREATED_DATE");
            DropColumn("dbo.Item", "CREATED_DATE");
            DropColumn("dbo.ItemDemandDetail", "CREATED_DATE");
            DropColumn("dbo.ItemDemandMaster", "CREATED_DATE");
            DropColumn("dbo.User", "CREATED_DATE");
            DropColumn("dbo.ProjectManager", "CREATED_DATE");
            DropColumn("dbo.PayoffDetail", "CREATED_DATE");
            DropColumn("dbo.MenuRole", "CREATED_DATE");
            DropColumn("dbo.StockDetail", "CREATED_DATE");
            DropColumn("dbo.StockMaster", "CREATED_DATE");
            DropColumn("dbo.UserRole", "CREATED_DATE");
            DropColumn("dbo.ParameterMaster", "CREATED_DATE");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ParameterMaster", "CREATED_DATE", c => c.String());
            AddColumn("dbo.UserRole", "CREATED_DATE", c => c.String());
            AddColumn("dbo.StockMaster", "CREATED_DATE", c => c.String());
            AddColumn("dbo.StockDetail", "CREATED_DATE", c => c.String());
            AddColumn("dbo.MenuRole", "CREATED_DATE", c => c.String());
            AddColumn("dbo.PayoffDetail", "CREATED_DATE", c => c.String());
            AddColumn("dbo.ProjectManager", "CREATED_DATE", c => c.String());
            AddColumn("dbo.User", "CREATED_DATE", c => c.String());
            AddColumn("dbo.ItemDemandMaster", "CREATED_DATE", c => c.String());
            AddColumn("dbo.ItemDemandDetail", "CREATED_DATE", c => c.String());
            AddColumn("dbo.Item", "CREATED_DATE", c => c.String());
            AddColumn("dbo.ProjectExplore", "CREATED_DATE", c => c.String());
            AddColumn("dbo.PayoffDefault", "CREATED_DATE", c => c.String());
            AddColumn("dbo.PayoffControl", "CREATED_DATE", c => c.String());
            AddColumn("dbo.PayoffMaster", "CREATED_DATE", c => c.String());
            AddColumn("dbo.Contract", "CREATED_DATE", c => c.String());
            AddColumn("dbo.Project", "CREATED_DATE", c => c.String());
            AddColumn("dbo.ParameterDetail", "CREATED_DATE", c => c.String());
            AddColumn("dbo.Company", "CREATED_DATE", c => c.String());
        }
    }
}
