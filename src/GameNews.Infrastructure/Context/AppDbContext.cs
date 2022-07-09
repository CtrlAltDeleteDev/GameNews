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
                .HasOne(r => r.Blog)
                .WithMany(t => t.Posts)
                .OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<PostTagEntity>()
              .HasKey(t => new { t.PostId, t.TagId });

            modelBuilder.Entity<PostTagEntity>()
                .HasOne(pt => pt.Post)
                .WithMany(p => p.PostTags)
                .HasForeignKey(pt => pt.PostId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<PostTagEntity>()
                .HasOne(pt => pt.Tag)
                .WithMany(t => t.PostTags)
                .HasForeignKey(pt => pt.TagId)
                .OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<SubscriptionEntity>()
             .HasKey(t => new { t.UserId, t.BlogId });

            modelBuilder.Entity<SubscriptionEntity>()
               .HasOne(pt => pt.User)
               .WithMany(p => p.Subscriptions)
               .HasForeignKey(pt => pt.UserId)
               .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<SubscriptionEntity>()
                .HasOne(pt => pt.Blog)
                .WithMany(t => t.Subscriptions)
                .HasForeignKey(pt => pt.BlogId)
                .OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<OwnershipEntity>()
             .HasKey(t => new { t.UserId, t.BlogId });

            modelBuilder.Entity<OwnershipEntity>()
               .HasOne(pt => pt.User)
               .WithMany(p => p.Ownerships)
               .HasForeignKey(pt => pt.UserId)
               .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<OwnershipEntity>()
                .HasOne(pt => pt.Blog)
                .WithMany(t => t.Ownerships)
                .HasForeignKey(pt => pt.BlogId)
                .OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<LikesEntity>()
            .HasKey(t => new { t.UserId, t.PostId });

            modelBuilder.Entity<LikesEntity>()
               .HasOne(pt => pt.User)
               .WithMany(p => p.Likes)
               .HasForeignKey(pt => pt.UserId)
               .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<LikesEntity>()
                .HasOne(pt => pt.Post)
                .WithMany(t => t.Likes)
                .HasForeignKey(pt => pt.PostId)
                .OnDelete(DeleteBehavior.Cascade);

        }

    }
}


