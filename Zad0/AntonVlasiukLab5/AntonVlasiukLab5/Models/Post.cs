using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AntonVlasiukLab5.Models
{
    public class Post : ModelBase
    {
        [Required]
        public string Title { get; set; }
        [Required]
        [MinLength(10)]
        public string Body { get; set; }
        //we don`t using it, because we don't have how to login for identify an Author
        //public virtual Author Author { get; set; }
        public virtual IEnumerable<Comment> Comments { get; set; }
    }

}
