namespace AntonVlasiukLab5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RequiresAndMinLength : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Posts", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.Posts", "Body", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Posts", "Body", c => c.String());
            AlterColumn("dbo.Posts", "Title", c => c.String());
        }
    }
}
