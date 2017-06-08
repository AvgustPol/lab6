using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AntonVlasiukLab5Home.Models
{
    public class SchoolContext : DbContext
    {
        public IDbSet<SchoolClass> SchoolClasses { get; set; }
        public IDbSet<Student> Students { get; set; }
        public IDbSet<Adres> Adreses { get; set;}

        public SchoolContext() : base("MyNewSchool"){ }
    }
}