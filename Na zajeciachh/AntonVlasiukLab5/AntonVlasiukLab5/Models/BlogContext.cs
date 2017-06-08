using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AntonVlasiukLab5.Models
{
    public class BlogContext : DbContext
    {
        public IDbSet<Post> Posts { get; set; }

        public BlogContext() : base("MyNewBlog"){}
    }
}