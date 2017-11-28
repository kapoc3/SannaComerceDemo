namespace SannaComerce.Infrastructure.Repositories.Sql.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class kapoc2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "Code", c => c.String(nullable: false));
            AlterColumn("dbo.Products", "Description", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Description", c => c.String());
            AlterColumn("dbo.Products", "Code", c => c.String());
        }
    }
}
