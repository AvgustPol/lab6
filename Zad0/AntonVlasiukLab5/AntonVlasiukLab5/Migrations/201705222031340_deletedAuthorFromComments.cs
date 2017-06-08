namespace AntonVlasiukLab5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletedAuthorFromComments : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Comments", "Author_Id", "dbo.Authors");
            DropIndex("dbo.Comments", new[] { "Author_Id" });
            DropColumn("dbo.Comments", "Author_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Comments", "Author_Id", c => c.Int());
            CreateIndex("dbo.Comments", "Author_Id");
            AddForeignKey("dbo.Comments", "Author_Id", "dbo.Authors", "Id");
        }
    }
}
