namespace WiodySM.Data.Configuration
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v14 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Project", "PROJECT_ISDELIVERYEXPLORE", c => c.Boolean(nullable: false));
            AddColumn("dbo.ProjectExplore", "PROJECTEXPLORE_PLACEITEMQUANTITY", c => c.Double(nullable: false));
            AddColumn("dbo.ProjectExplore", "PROJECTEXPLORE_PLACEITEMPRICE", c => c.Double(nullable: false));
            AddColumn("dbo.ProjectExplore", "PROJECTEXPLORE_PLACEITEMASSMPRICE", c => c.Double(nullable: false));
            AddColumn("dbo.ProjectExplore", "PROJECTEXPLORE_PLACEITEMDEASSMPRICE", c => c.Double(nullable: false));
            AddColumn("dbo.ProjectExplore", "PROJECTEXPLORE_PLACEITEMDEASSMDEPRICE", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ProjectExplore", "PROJECTEXPLORE_PLACEITEMDEASSMDEPRICE");
            DropColumn("dbo.ProjectExplore", "PROJECTEXPLORE_PLACEITEMDEASSMPRICE");
            DropColumn("dbo.ProjectExplore", "PROJECTEXPLORE_PLACEITEMASSMPRICE");
            DropColumn("dbo.ProjectExplore", "PROJECTEXPLORE_PLACEITEMPRICE");
            DropColumn("dbo.ProjectExplore", "PROJECTEXPLORE_PLACEITEMQUANTITY");
            DropColumn("dbo.Project", "PROJECT_ISDELIVERYEXPLORE");
        }
    }
}
