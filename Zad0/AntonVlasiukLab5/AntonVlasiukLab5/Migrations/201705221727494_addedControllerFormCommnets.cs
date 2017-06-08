namespace AntonVlasiukLab5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedControllerFormCommnets : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Content = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                        Author_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Authors", t => t.Author_Id)
                .Index(t => t.Author_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comments", "Author_Id", "dbo.Authors");
            DropIndex("dbo.Comments", new[] { "Author_Id" });
            DropTable("dbo.Comments");
        }
    }
}
