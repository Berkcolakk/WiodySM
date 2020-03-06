namespace WiodySM.Data.Configuration
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v8 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PayoffControl", "PAYOFFCONTROL_TYPE_ID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PayoffControl", "PAYOFFCONTROL_TYPE_ID");
        }
    }
}
