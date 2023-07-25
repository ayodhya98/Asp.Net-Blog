using Microsoft.EntityFrameworkCore;
using test2.Models.Domain;

namespace test2.Data
{
    public class BloggieDbContext : DbContext
    {
        public BloggieDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<BlogPost> blogPosts { get; set; }

        public DbSet<Tag> tags { get; set; }


    }
}
