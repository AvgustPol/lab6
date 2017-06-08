using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AntonVlasiukLab5Home.Models
{
    public class SchoolClass : ModelBase
    {
        public string ClassName { get; set; }
        public List<Student> Students { get; set; }
    }
}