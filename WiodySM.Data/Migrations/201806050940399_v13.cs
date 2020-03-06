namespace WiodySM.Data.Configuration
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v13 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProjectExplore", "PROJECTEXPLORE_ITEMPRICE", c => c.Double(nullable: false));
            AddColumn("dbo.ProjectExplore", "PROJECTEXPLORE_ITEMASSMPRICE", c => c.Double(nullable: false));
            AddColumn("dbo.ProjectExplore", "PROJECTEXPLORE_ITEMDEASSMPRICE", c => c.Double(nullable: false));
            AddColumn("dbo.ProjectExplore", "PROJECTEXPLORE_ITEMDEASSMDEPRICE", c => c.Double(nullable: false));
            DropColumn("dbo.ProjectExplore", "PROJECTEXPLORE_ITEMASSMQUANTITY");
            DropColumn("dbo.ProjectExplore", "PROJECTEXPLORE_ITEMDEASSMQUANTITY");
            DropColumn("dbo.ProjectExplore", "PROJECTEXPLORE_ITEMDEASSMDEQUANTITY");
            DropColumn("dbo.ProjectExplore", "PROJECTEXPLORE_ITEMCOUNT");
            DropColumn("dbo.ProjectExplore", "PROJECTEXPLORE_DESC2");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProjectExplore", "PROJECTEXPLORE_DESC2", c => c.String());
            AddColumn("dbo.ProjectExplore", "PROJECTEXPLORE_ITEMCOUNT", c => c.Double(nullable: false));
            AddColumn("dbo.ProjectExplore", "PROJECTEXPLORE_ITEMDEASSMDEQUANTITY", c => c.Double(nullable: false));
            AddColumn("dbo.ProjectExplore", "PROJECTEXPLORE_ITEMDEASSMQUANTITY", c => c.Double(nullable: false));
            AddColumn("dbo.ProjectExplore", "PROJECTEXPLORE_ITEMASSMQUANTITY", c => c.Double(nullable: false));
            DropColumn("dbo.ProjectExplore", "PROJECTEXPLORE_ITEMDEASSMDEPRICE");
            DropColumn("dbo.ProjectExplore", "PROJECTEXPLORE_ITEMDEASSMPRICE");
            DropColumn("dbo.ProjectExplore", "PROJECTEXPLORE_ITEMASSMPRICE");
            DropColumn("dbo.ProjectExplore", "PROJECTEXPLORE_ITEMPRICE");
        }
    }
}
