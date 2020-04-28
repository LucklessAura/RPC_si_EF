using Microsoft.EntityFrameworkCore;

namespace GrpcService.Model
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>().HasKey(t => t.PostId);
            modelBuilder.Entity<Comment>().HasKey(t => t.CommentId);
            modelBuilder.Entity<Comment>().HasOne(t => t.Post)
                .WithMany(t => t.Comments)
                .HasForeignKey(t => t.PostPostId);
        }

        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
    }
}
