namespace AntonVlasiukLab5.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AntonVlasiukLab5.Models.BlogContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AntonVlasiukLab5.Models.BlogContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Posts.AddOrUpdate(
                p => p.Title , 
                new Post { Title = "Hello kredek! 1", Body = "CPC-207-1-Kredek 1 ", Author = new Author { FirstName = "A", LastName = "A", UserName = "A" } },
                new Post { Title = "Hello kredek! 2", Body = "CPC-207-1-Kredek 2 ", Author = new Author { FirstName = "B", LastName = "B", UserName = "B" } },
                new Post { Title = "Hello kredek! 3", Body = "CPC-207-1-Kredek 3 ", Author = new Author { FirstName = "C", LastName = "C", UserName = "C" } }
                );
                // проверка есть ли такое. ≈сли да - обновить
        }
    }
}
