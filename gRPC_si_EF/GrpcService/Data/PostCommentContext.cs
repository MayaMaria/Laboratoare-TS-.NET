using GrpcService.Models;
using Microsoft.EntityFrameworkCore;


namespace GrpcService.Data
{
    public class PostCommentContext : DbContext
    {
        public PostCommentContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
