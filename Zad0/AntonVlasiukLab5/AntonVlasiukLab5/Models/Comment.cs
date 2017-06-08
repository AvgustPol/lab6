using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AntonVlasiukLab5.Models
{
    public class Comment : ModelBase
    {
        // we don`t using it, because we don't have how to login for identify an Author
        //public virtual Author Author { get; set; }
        public string Content { get; set; }
        public Post Post { get; set; }
    }
}