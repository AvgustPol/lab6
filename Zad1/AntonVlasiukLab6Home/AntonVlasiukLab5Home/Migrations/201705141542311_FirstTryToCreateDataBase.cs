namespace AntonVlasiukLab5Home.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstTryToCreateDataBase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SchoolClasses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClassName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Age = c.Int(nullable: false),
                        Adres_Id = c.Int(),
                        SchoolClass_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Adres", t => t.Adres_Id)
                .ForeignKey("dbo.SchoolClasses", t => t.SchoolClass_Id)
                .Index(t => t.Adres_Id)
                .Index(t => t.SchoolClass_Id);
            
            CreateTable(
                "dbo.Adres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        City = c.String(),
                        Street = c.String(),
                        House = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Hobbies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Student_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.Student_Id)
                .Index(t => t.Student_Id);
            
            CreateTable(
                "dbo.Prizes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Signature = c.String(),
                        Comment = c.String(),
                        Where_Id = c.Int(),
                        Hobby_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Adres", t => t.Where_Id)
                .ForeignKey("dbo.Hobbies", t => t.Hobby_Id)
                .Index(t => t.Where_Id)
                .Index(t => t.Hobby_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "SchoolClass_Id", "dbo.SchoolClasses");
            DropForeignKey("dbo.Hobbies", "Student_Id", "dbo.Students");
            DropForeignKey("dbo.Prizes", "Hobby_Id", "dbo.Hobbies");
            DropForeignKey("dbo.Prizes", "Where_Id", "dbo.Adres");
            DropForeignKey("dbo.Students", "Adres_Id", "dbo.Adres");
            DropIndex("dbo.Prizes", new[] { "Hobby_Id" });
            DropIndex("dbo.Prizes", new[] { "Where_Id" });
            DropIndex("dbo.Hobbies", new[] { "Student_Id" });
            DropIndex("dbo.Students", new[] { "SchoolClass_Id" });
            DropIndex("dbo.Students", new[] { "Adres_Id" });
            DropTable("dbo.Prizes");
            DropTable("dbo.Hobbies");
            DropTable("dbo.Adres");
            DropTable("dbo.Students");
            DropTable("dbo.SchoolClasses");
        }
    }
}
