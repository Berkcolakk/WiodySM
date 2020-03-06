namespace WiodySM.Data.Configuration
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v17 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.User", "USER_EMAIL", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.User", "USER_EMAIL");
        }
    }
}
