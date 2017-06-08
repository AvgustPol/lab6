namespace AntonVlasiukLab5Home.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AntonVlasiukLab5Home.Models.SchoolContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AntonVlasiukLab5Home.Models.SchoolContext context)
        {

            SchoolClass tmpClass = new SchoolClass()
            {
                ClassName = "2a"
            };

            context.SchoolClasses.AddOrUpdate(
                p => p.ClassName, tmpClass);

        }
    }
}
