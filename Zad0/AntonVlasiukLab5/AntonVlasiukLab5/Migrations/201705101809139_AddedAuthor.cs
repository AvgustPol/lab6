namespace AntonVlasiukLab5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAuthor : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        UserName = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Posts", "Author_Id", c => c.Int());
            CreateIndex("dbo.Posts", "Author_Id");
            AddForeignKey("dbo.Posts", "Author_Id", "dbo.Authors", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "Author_Id", "dbo.Authors");
            DropIndex("dbo.Posts", new[] { "Author_Id" });
            DropColumn("dbo.Posts", "Author_Id");
            DropTable("dbo.Authors");
        }
    }
}
