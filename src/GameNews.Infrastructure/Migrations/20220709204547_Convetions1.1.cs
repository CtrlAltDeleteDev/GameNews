using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameNews.Infrastructure.Migrations
{
    public partial class Convetions11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_likes_posts_PostId",
                table: "likes");

            migrationBuilder.DropForeignKey(
                name: "FK_likes_UserEntity_UserId",
                table: "likes");

            migrationBuilder.DropForeignKey(
                name: "FK_ownerships_blogs_BlogId",
                table: "ownerships");

            migrationBuilder.DropForeignKey(
                name: "FK_ownerships_UserEntity_UserId",
                table: "ownerships");

            migrationBuilder.DropForeignKey(
                name: "FK_posts_blogs_BlogId",
                table: "posts");

            migrationBuilder.DropForeignKey(
                name: "FK_postTags_posts_PostId",
                table: "postTags");

            migrationBuilder.DropForeignKey(
                name: "FK_postTags_tags_TagId",
                table: "postTags");

            migrationBuilder.DropForeignKey(
                name: "FK_subscriptions_blogs_BlogId",
                table: "subscriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_subscriptions_UserEntity_UserId",
                table: "subscriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tags",
                table: "tags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_subscriptions",
                table: "subscriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_postTags",
                table: "postTags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_posts",
                table: "posts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ownerships",
                table: "ownerships");

            migrationBuilder.DropPrimaryKey(
                name: "PK_likes",
                table: "likes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_blogs",
                table: "blogs");

            migrationBuilder.RenameTable(
                name: "tags",
                newName: "Tags");

            migrationBuilder.RenameTable(
                name: "subscriptions",
                newName: "Subscriptions");

            migrationBuilder.RenameTable(
                name: "postTags",
                newName: "PostTags");

            migrationBuilder.RenameTable(
                name: "posts",
                newName: "Posts");

            migrationBuilder.RenameTable(
                name: "ownerships",
                newName: "Ownerships");

            migrationBuilder.RenameTable(
                name: "likes",
                newName: "Likes");

            migrationBuilder.RenameTable(
                name: "blogs",
                newName: "Blogs");

            migrationBuilder.RenameIndex(
                name: "IX_subscriptions_BlogId",
                table: "Subscriptions",
                newName: "IX_Subscriptions_BlogId");

            migrationBuilder.RenameIndex(
                name: "IX_postTags_TagId",
                table: "PostTags",
                newName: "IX_PostTags_TagId");

            migrationBuilder.RenameIndex(
                name: "IX_posts_BlogId",
                table: "Posts",
                newName: "IX_Posts_BlogId");

            migrationBuilder.RenameIndex(
                name: "IX_ownerships_BlogId",
                table: "Ownerships",
                newName: "IX_Ownerships_BlogId");

            migrationBuilder.RenameIndex(
                name: "IX_likes_PostId",
                table: "Likes",
                newName: "IX_Likes_PostId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tags",
                table: "Tags",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Subscriptions",
                table: "Subscriptions",
                columns: new[] { "UserId", "BlogId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_PostTags",
                table: "PostTags",
                columns: new[] { "PostId", "TagId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Posts",
                table: "Posts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ownerships",
                table: "Ownerships",
                columns: new[] { "UserId", "BlogId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Likes",
                table: "Likes",
                columns: new[] { "UserId", "PostId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Blogs",
                table: "Blogs",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Likes_Posts_PostId",
                table: "Likes",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Likes_UserEntity_UserId",
                table: "Likes",
                column: "UserId",
                principalTable: "UserEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ownerships_Blogs_BlogId",
                table: "Ownerships",
                column: "BlogId",
                principalTable: "Blogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ownerships_UserEntity_UserId",
                table: "Ownerships",
                column: "UserId",
                principalTable: "UserEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Blogs_BlogId",
                table: "Posts",
                column: "BlogId",
                principalTable: "Blogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PostTags_Posts_PostId",
                table: "PostTags",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PostTags_Tags_TagId",
                table: "PostTags",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subscriptions_Blogs_BlogId",
                table: "Subscriptions",
                column: "BlogId",
                principalTable: "Blogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subscriptions_UserEntity_UserId",
                table: "Subscriptions",
                column: "UserId",
                principalTable: "UserEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Likes_Posts_PostId",
                table: "Likes");

            migrationBuilder.DropForeignKey(
                name: "FK_Likes_UserEntity_UserId",
                table: "Likes");

            migrationBuilder.DropForeignKey(
                name: "FK_Ownerships_Blogs_BlogId",
                table: "Ownerships");

            migrationBuilder.DropForeignKey(
                name: "FK_Ownerships_UserEntity_UserId",
                table: "Ownerships");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Blogs_BlogId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_PostTags_Posts_PostId",
                table: "PostTags");

            migrationBuilder.DropForeignKey(
                name: "FK_PostTags_Tags_TagId",
                table: "PostTags");

            migrationBuilder.DropForeignKey(
                name: "FK_Subscriptions_Blogs_BlogId",
                table: "Subscriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Subscriptions_UserEntity_UserId",
                table: "Subscriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tags",
                table: "Tags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Subscriptions",
                table: "Subscriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PostTags",
                table: "PostTags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Posts",
                table: "Posts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ownerships",
                table: "Ownerships");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Likes",
                table: "Likes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Blogs",
                table: "Blogs");

            migrationBuilder.RenameTable(
                name: "Tags",
                newName: "tags");

            migrationBuilder.RenameTable(
                name: "Subscriptions",
                newName: "subscriptions");

            migrationBuilder.RenameTable(
                name: "PostTags",
                newName: "postTags");

            migrationBuilder.RenameTable(
                name: "Posts",
                newName: "posts");

            migrationBuilder.RenameTable(
                name: "Ownerships",
                newName: "ownerships");

            migrationBuilder.RenameTable(
                name: "Likes",
                newName: "likes");

            migrationBuilder.RenameTable(
                name: "Blogs",
                newName: "blogs");

            migrationBuilder.RenameIndex(
                name: "IX_Subscriptions_BlogId",
                table: "subscriptions",
                newName: "IX_subscriptions_BlogId");

            migrationBuilder.RenameIndex(
                name: "IX_PostTags_TagId",
                table: "postTags",
                newName: "IX_postTags_TagId");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_BlogId",
                table: "posts",
                newName: "IX_posts_BlogId");

            migrationBuilder.RenameIndex(
                name: "IX_Ownerships_BlogId",
                table: "ownerships",
                newName: "IX_ownerships_BlogId");

            migrationBuilder.RenameIndex(
                name: "IX_Likes_PostId",
                table: "likes",
                newName: "IX_likes_PostId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tags",
                table: "tags",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_subscriptions",
                table: "subscriptions",
                columns: new[] { "UserId", "BlogId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_postTags",
                table: "postTags",
                columns: new[] { "PostId", "TagId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_posts",
                table: "posts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ownerships",
                table: "ownerships",
                columns: new[] { "UserId", "BlogId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_likes",
                table: "likes",
                columns: new[] { "UserId", "PostId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_blogs",
                table: "blogs",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_likes_posts_PostId",
                table: "likes",
                column: "PostId",
                principalTable: "posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_likes_UserEntity_UserId",
                table: "likes",
                column: "UserId",
                principalTable: "UserEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ownerships_blogs_BlogId",
                table: "ownerships",
                column: "BlogId",
                principalTable: "blogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ownerships_UserEntity_UserId",
                table: "ownerships",
                column: "UserId",
                principalTable: "UserEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_posts_blogs_BlogId",
                table: "posts",
                column: "BlogId",
                principalTable: "blogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_postTags_posts_PostId",
                table: "postTags",
                column: "PostId",
                principalTable: "posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_postTags_tags_TagId",
                table: "postTags",
                column: "TagId",
                principalTable: "tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_subscriptions_blogs_BlogId",
                table: "subscriptions",
                column: "BlogId",
                principalTable: "blogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_subscriptions_UserEntity_UserId",
                table: "subscriptions",
                column: "UserId",
                principalTable: "UserEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
