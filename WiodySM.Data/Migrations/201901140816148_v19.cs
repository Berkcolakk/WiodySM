namespace WiodySM.Data.Configuration
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v19 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Company", "MACHINENAME_MACHINEIDENTITY", c => c.String());
            AddColumn("dbo.ParameterDetail", "MACHINENAME_MACHINEIDENTITY", c => c.String());
            AddColumn("dbo.Project", "MACHINENAME_MACHINEIDENTITY", c => c.String());
            AddColumn("dbo.Contract", "MACHINENAME_MACHINEIDENTITY", c => c.String());
            AddColumn("dbo.PayoffMaster", "MACHINENAME_MACHINEIDENTITY", c => c.String());
            AddColumn("dbo.PayoffControl", "MACHINENAME_MACHINEIDENTITY", c => c.String());
            AddColumn("dbo.PayoffDefault", "MACHINENAME_MACHINEIDENTITY", c => c.String());
            AddColumn("dbo.ProjectExplore", "MACHINENAME_MACHINEIDENTITY", c => c.String());
            AddColumn("dbo.Item", "MACHINENAME_MACHINEIDENTITY", c => c.String());
            AddColumn("dbo.ItemDemandDetail", "MACHINENAME_MACHINEIDENTITY", c => c.String());
            AddColumn("dbo.ItemDemandMaster", "MACHINENAME_MACHINEIDENTITY", c => c.String());
            AddColumn("dbo.User", "MACHINENAME_MACHINEIDENTITY", c => c.String());
            AddColumn("dbo.ProjectManager", "MACHINENAME_MACHINEIDENTITY", c => c.String());
            AddColumn("dbo.PayoffDetail", "MACHINENAME_MACHINEIDENTITY", c => c.String());
            AddColumn("dbo.MenuRole", "MACHINENAME_MACHINEIDENTITY", c => c.String());
            AddColumn("dbo.StockDetail", "MACHINENAME_MACHINEIDENTITY", c => c.String());
            AddColumn("dbo.StockMaster", "MACHINENAME_MACHINEIDENTITY", c => c.String());
            AddColumn("dbo.UserRole", "MACHINENAME_MACHINEIDENTITY", c => c.String());
            AddColumn("dbo.ParameterMaster", "MACHINENAME_MACHINEIDENTITY", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ParameterMaster", "MACHINENAME_MACHINEIDENTITY");
            DropColumn("dbo.UserRole", "MACHINENAME_MACHINEIDENTITY");
            DropColumn("dbo.StockMaster", "MACHINENAME_MACHINEIDENTITY");
            DropColumn("dbo.StockDetail", "MACHINENAME_MACHINEIDENTITY");
            DropColumn("dbo.MenuRole", "MACHINENAME_MACHINEIDENTITY");
            DropColumn("dbo.PayoffDetail", "MACHINENAME_MACHINEIDENTITY");
            DropColumn("dbo.ProjectManager", "MACHINENAME_MACHINEIDENTITY");
            DropColumn("dbo.User", "MACHINENAME_MACHINEIDENTITY");
            DropColumn("dbo.ItemDemandMaster", "MACHINENAME_MACHINEIDENTITY");
            DropColumn("dbo.ItemDemandDetail", "MACHINENAME_MACHINEIDENTITY");
            DropColumn("dbo.Item", "MACHINENAME_MACHINEIDENTITY");
            DropColumn("dbo.ProjectExplore", "MACHINENAME_MACHINEIDENTITY");
            DropColumn("dbo.PayoffDefault", "MACHINENAME_MACHINEIDENTITY");
            DropColumn("dbo.PayoffControl", "MACHINENAME_MACHINEIDENTITY");
            DropColumn("dbo.PayoffMaster", "MACHINENAME_MACHINEIDENTITY");
            DropColumn("dbo.Contract", "MACHINENAME_MACHINEIDENTITY");
            DropColumn("dbo.Project", "MACHINENAME_MACHINEIDENTITY");
            DropColumn("dbo.ParameterDetail", "MACHINENAME_MACHINEIDENTITY");
            DropColumn("dbo.Company", "MACHINENAME_MACHINEIDENTITY");
        }
    }
}
