namespace WiodySM.Data.Configuration
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v9 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Project", "PROJECT_GROUP", c => c.String());
            AddColumn("dbo.Contract", "CONTRACT_PRICECUTRATE", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contract", "CONTRACT_PRICECUTRATE");
            DropColumn("dbo.Project", "PROJECT_GROUP");
        }
    }
}
