namespace WiodySM.Data.Configuration
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MenuRole",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MENUROLE_MENU_ID = c.Int(nullable: false),
                        MENUROLE_ROLE_ID = c.Int(nullable: false),
                        CREATED_DATE = c.String(),
                        CREATED_USER_ID = c.Int(nullable: false),
                        CREATED_USER_IP = c.String(),
                        ISACTIVE = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ParameterDetail", t => t.MENUROLE_MENU_ID)
                .ForeignKey("dbo.ParameterDetail", t => t.MENUROLE_ROLE_ID)
                .Index(t => t.MENUROLE_MENU_ID)
                .Index(t => t.MENUROLE_ROLE_ID);
            
            CreateTable(
                "dbo.UserRole",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        USERROLE_USER_ID = c.Int(nullable: false),
                        USERROLE_ROLE_ID = c.Int(nullable: false),
                        CREATED_DATE = c.String(),
                        CREATED_USER_ID = c.Int(nullable: false),
                        CREATED_USER_IP = c.String(),
                        ISACTIVE = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.User", t => t.USERROLE_USER_ID)
                .ForeignKey("dbo.ParameterDetail", t => t.USERROLE_ROLE_ID)
                .Index(t => t.USERROLE_USER_ID)
                .Index(t => t.USERROLE_ROLE_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserRole", "USERROLE_ROLE_ID", "dbo.ParameterDetail");
            DropForeignKey("dbo.UserRole", "USERROLE_USER_ID", "dbo.User");
            DropForeignKey("dbo.MenuRole", "MENUROLE_ROLE_ID", "dbo.ParameterDetail");
            DropForeignKey("dbo.MenuRole", "MENUROLE_MENU_ID", "dbo.ParameterDetail");
            DropIndex("dbo.UserRole", new[] { "USERROLE_ROLE_ID" });
            DropIndex("dbo.UserRole", new[] { "USERROLE_USER_ID" });
            DropIndex("dbo.MenuRole", new[] { "MENUROLE_ROLE_ID" });
            DropIndex("dbo.MenuRole", new[] { "MENUROLE_MENU_ID" });
            DropTable("dbo.UserRole");
            DropTable("dbo.MenuRole");
        }
    }
}
