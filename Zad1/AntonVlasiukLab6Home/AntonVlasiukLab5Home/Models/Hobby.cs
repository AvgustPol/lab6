using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AntonVlasiukLab5Home.Models
{
    public class Hobby : ModelBase
    {
        /// <summary>
        /// name of Hobby
        /// </summary>
        public string Name { get; set; }
        public List<Prize> Prizes { get; set; }
    }
}