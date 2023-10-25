using Microsoft.EntityFrameworkCore;
using UniversoEstudantil.Models.Domain;

namespace UniversoEstudantil.Data
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext()
        {
        }

        public BlogDbContext(DbContextOptions options) : base(options) 
        { 
        
        }
        // TABLES that will be created
        public DbSet<BlogPost> BlogPosts { get; set; } 
        public DbSet<BlogTags> BlogTags { get; set; }

        //public int MyProperty { get; set; } //a table to connect these two database, because they hav a relationship
    } 
}
