using Microsoft.EntityFrameworkCore;
using SampleMVCGrid.Models;
using System.Linq;

namespace SampleMVCGrid
{
    public class SampleDbContext:DbContext
    {
        public SampleDbContext(DbContextOptions<SampleDbContext> options):
            base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Post>().HasKey(m => m.id);
            builder.Entity<Comment>().HasKey(m => m.id);

            base.OnModelCreating(builder);
        }

        public DbSet<Post> Posts { get; set; }

        public DbSet<Comment> Comments { get; set; }
    }
}