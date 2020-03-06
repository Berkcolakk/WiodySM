namespace WiodySM.Data.Configuration
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v15 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProjectExplore", "PROJECTEXPLORE_CODE", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ProjectExplore", "PROJECTEXPLORE_CODE");
        }
    }
}
