namespace Crud.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Profiles", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Profiles", "Bio", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.Profiles", "Favorite", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Profiles", "LastAte", c => c.String(nullable: false, maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Profiles", "LastAte", c => c.String());
            AlterColumn("dbo.Profiles", "Favorite", c => c.String());
            AlterColumn("dbo.Profiles", "Bio", c => c.String());
            AlterColumn("dbo.Profiles", "Name", c => c.String());
        }
    }
}
