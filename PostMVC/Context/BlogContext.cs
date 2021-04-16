using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using PostMVC.Models;

namespace PostMVC.Context
{
    
    public class BlogContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Post> Posts{ get; set; }
        public DbSet<Category> Categories{ get; set; }
    }
}