using GameNews.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace GameNews.Infrastructure.Context
{
	public class AppDbContext : DbContext
	{
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<BlogEntity> blogs { get; set; }

        public DbSet<PostEntity> posts { get; set; }

        public DbSet<TagEntity> tags { get; set; }

        public DbSet<OwnershipEntity> ownerships { get; set; }

        public DbSet<SubscriptionEntity> subscriptions { get; set; }

        public DbSet<PostTagEntity> postTags { get; set; }

        public DbSet<LikesEntity> likes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PostEntity>()
                .HasOne(r => r.blog)
                .WithMany(t => t.posts)
                .OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<PostTagEntity>()
              .HasKey(t => new { t.postId, t.tagId });

            modelBuilder.Entity<PostTagEntity>()
                .HasOne(pt => pt.post)
                .WithMany(p => p.postTags)
                .HasForeignKey(pt => pt.postId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<PostTagEntity>()
                .HasOne(pt => pt.tag)
                .WithMany(t => t.postTags)
                .HasForeignKey(pt => pt.tagId)
                .OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<SubscriptionEntity>()
             .HasKey(t => new { t.userId, t.blogId });

            modelBuilder.Entity<SubscriptionEntity>()
               .HasOne(pt => pt.user)
               .WithMany(p => p.subscriptions)
               .HasForeignKey(pt => pt.userId)
               .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<SubscriptionEntity>()
                .HasOne(pt => pt.blog)
                .WithMany(t => t.subscriptions)
                .HasForeignKey(pt => pt.blogId)
                .OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<OwnershipEntity>()
             .HasKey(t => new { t.userId, t.blogId });

            modelBuilder.Entity<OwnershipEntity>()
               .HasOne(pt => pt.user)
               .WithMany(p => p.ownerships)
               .HasForeignKey(pt => pt.userId)
               .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<OwnershipEntity>()
                .HasOne(pt => pt.blog)
                .WithMany(t => t.ownerships)
                .HasForeignKey(pt => pt.blogId)
                .OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<LikesEntity>()
            .HasKey(t => new { t.userId, t.postId });

            modelBuilder.Entity<LikesEntity>()
               .HasOne(pt => pt.user)
               .WithMany(p => p.likes)
               .HasForeignKey(pt => pt.userId)
               .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<LikesEntity>()
                .HasOne(pt => pt.post)
                .WithMany(t => t.likes)
                .HasForeignKey(pt => pt.postId)
                .OnDelete(DeleteBehavior.Cascade);

        }

    }
}


