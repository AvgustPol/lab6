namespace AntonVlasiukLab5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletedAuthorsFromPost : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Posts", "Author_Id", "dbo.Authors");
            DropIndex("dbo.Posts", new[] { "Author_Id" });
            DropColumn("dbo.Posts", "Author_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Posts", "Author_Id", c => c.Int());
            CreateIndex("dbo.Posts", "Author_Id");
            AddForeignKey("dbo.Posts", "Author_Id", "dbo.Authors", "Id");
        }
    }
}
