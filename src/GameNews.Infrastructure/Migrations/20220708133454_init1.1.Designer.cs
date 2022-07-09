﻿// <auto-generated />
using GameNews.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GameNews.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220708133454_init1.1")]
    partial class init11
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GameNews.Infrastructure.Entities.BlogEntity", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("blogs");
                });

            modelBuilder.Entity("GameNews.Infrastructure.Entities.LikesEntity", b =>
                {
                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.Property<int>("postId")
                        .HasColumnType("int");

                    b.HasKey("userId", "postId");

                    b.HasIndex("postId");

                    b.ToTable("likes");
                });

            modelBuilder.Entity("GameNews.Infrastructure.Entities.OwnershipEntity", b =>
                {
                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.Property<int>("blogId")
                        .HasColumnType("int");

                    b.HasKey("userId", "blogId");

                    b.HasIndex("blogId");

                    b.ToTable("ownerships");
                });

            modelBuilder.Entity("GameNews.Infrastructure.Entities.PostEntity", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("blogId")
                        .HasColumnType("int");

                    b.Property<string>("context")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("blogId");

                    b.ToTable("posts");
                });

            modelBuilder.Entity("GameNews.Infrastructure.Entities.PostTagEntity", b =>
                {
                    b.Property<int>("postId")
                        .HasColumnType("int");

                    b.Property<int>("tagId")
                        .HasColumnType("int");

                    b.HasKey("postId", "tagId");

                    b.HasIndex("tagId");

                    b.ToTable("postTags");
                });

            modelBuilder.Entity("GameNews.Infrastructure.Entities.SubscriptionEntity", b =>
                {
                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.Property<int>("blogId")
                        .HasColumnType("int");

                    b.HasKey("userId", "blogId");

                    b.HasIndex("blogId");

                    b.ToTable("subscriptions");
                });

            modelBuilder.Entity("GameNews.Infrastructure.Entities.TagEntity", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("tags");
                });

            modelBuilder.Entity("GameNews.Infrastructure.Entities.UserEntity", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.HasKey("id");

                    b.ToTable("UserEntity");
                });

            modelBuilder.Entity("GameNews.Infrastructure.Entities.LikesEntity", b =>
                {
                    b.HasOne("GameNews.Infrastructure.Entities.PostEntity", "post")
                        .WithMany("likes")
                        .HasForeignKey("postId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GameNews.Infrastructure.Entities.UserEntity", "user")
                        .WithMany("likes")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("post");

                    b.Navigation("user");
                });

            modelBuilder.Entity("GameNews.Infrastructure.Entities.OwnershipEntity", b =>
                {
                    b.HasOne("GameNews.Infrastructure.Entities.BlogEntity", "blog")
                        .WithMany("ownerships")
                        .HasForeignKey("blogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GameNews.Infrastructure.Entities.UserEntity", "user")
                        .WithMany("ownerships")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("blog");

                    b.Navigation("user");
                });

            modelBuilder.Entity("GameNews.Infrastructure.Entities.PostEntity", b =>
                {
                    b.HasOne("GameNews.Infrastructure.Entities.BlogEntity", "blog")
                        .WithMany("posts")
                        .HasForeignKey("blogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("blog");
                });

            modelBuilder.Entity("GameNews.Infrastructure.Entities.PostTagEntity", b =>
                {
                    b.HasOne("GameNews.Infrastructure.Entities.PostEntity", "post")
                        .WithMany("postTags")
                        .HasForeignKey("postId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GameNews.Infrastructure.Entities.TagEntity", "tag")
                        .WithMany("postTags")
                        .HasForeignKey("tagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("post");

                    b.Navigation("tag");
                });

            modelBuilder.Entity("GameNews.Infrastructure.Entities.SubscriptionEntity", b =>
                {
                    b.HasOne("GameNews.Infrastructure.Entities.BlogEntity", "blog")
                        .WithMany("subscriptions")
                        .HasForeignKey("blogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GameNews.Infrastructure.Entities.UserEntity", "user")
                        .WithMany("subscriptions")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("blog");

                    b.Navigation("user");
                });

            modelBuilder.Entity("GameNews.Infrastructure.Entities.BlogEntity", b =>
                {
                    b.Navigation("ownerships");

                    b.Navigation("posts");

                    b.Navigation("subscriptions");
                });

            modelBuilder.Entity("GameNews.Infrastructure.Entities.PostEntity", b =>
                {
                    b.Navigation("likes");

                    b.Navigation("postTags");
                });

            modelBuilder.Entity("GameNews.Infrastructure.Entities.TagEntity", b =>
                {
                    b.Navigation("postTags");
                });

            modelBuilder.Entity("GameNews.Infrastructure.Entities.UserEntity", b =>
                {
                    b.Navigation("likes");

                    b.Navigation("ownerships");

                    b.Navigation("subscriptions");
                });
#pragma warning restore 612, 618
        }
    }
}