using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AntonVlasiukLab5Home.Models
{
    public class Adres : ModelBase
    {
        public string City { get; set; }
        public string Street { get; set; }
        public int House { get; set; }
    }
}