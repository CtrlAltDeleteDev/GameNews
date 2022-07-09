using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameNews.Infrastructure.Migrations
{
    public partial class Convetions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_likes_posts_postId",
                table: "likes");

            migrationBuilder.DropForeignKey(
                name: "FK_likes_UserEntity_userId",
                table: "likes");

            migrationBuilder.DropForeignKey(
                name: "FK_ownerships_blogs_blogId",
                table: "ownerships");

            migrationBuilder.DropForeignKey(
                name: "FK_ownerships_UserEntity_userId",
                table: "ownerships");

            migrationBuilder.DropForeignKey(
                name: "FK_posts_blogs_blogId",
                table: "posts");

            migrationBuilder.DropForeignKey(
                name: "FK_postTags_posts_postId",
                table: "postTags");

            migrationBuilder.DropForeignKey(
                name: "FK_postTags_tags_tagId",
                table: "postTags");

            migrationBuilder.DropForeignKey(
                name: "FK_subscriptions_blogs_blogId",
                table: "subscriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_subscriptions_UserEntity_userId",
                table: "subscriptions");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "UserEntity",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "value",
                table: "tags",
                newName: "Value");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "tags",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "blogId",
                table: "subscriptions",
                newName: "BlogId");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "subscriptions",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_subscriptions_blogId",
                table: "subscriptions",
                newName: "IX_subscriptions_BlogId");

            migrationBuilder.RenameColumn(
                name: "tagId",
                table: "postTags",
                newName: "TagId");

            migrationBuilder.RenameColumn(
                name: "postId",
                table: "postTags",
                newName: "PostId");

            migrationBuilder.RenameIndex(
                name: "IX_postTags_tagId",
                table: "postTags",
                newName: "IX_postTags_TagId");

            migrationBuilder.RenameColumn(
                name: "context",
                table: "posts",
                newName: "Context");

            migrationBuilder.RenameColumn(
                name: "blogId",
                table: "posts",
                newName: "BlogId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "posts",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_posts_blogId",
                table: "posts",
                newName: "IX_posts_BlogId");

            migrationBuilder.RenameColumn(
                name: "blogId",
                table: "ownerships",
                newName: "BlogId");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "ownerships",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_ownerships_blogId",
                table: "ownerships",
                newName: "IX_ownerships_BlogId");

            migrationBuilder.RenameColumn(
                name: "postId",
                table: "likes",
                newName: "PostId");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "likes",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_likes_postId",
                table: "likes",
                newName: "IX_likes_PostId");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "blogs",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "blogs",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "blogs",
                newName: "Id");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "UserEntity",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Value",
                table: "tags",
                newName: "value");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "tags",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "BlogId",
                table: "subscriptions",
                newName: "blogId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "subscriptions",
                newName: "userId");

            migrationBuilder.RenameIndex(
                name: "IX_subscriptions_BlogId",
                table: "subscriptions",
                newName: "IX_subscriptions_blogId");

            migrationBuilder.RenameColumn(
                name: "TagId",
                table: "postTags",
                newName: "tagId");

            migrationBuilder.RenameColumn(
                name: "PostId",
                table: "postTags",
                newName: "postId");

            migrationBuilder.RenameIndex(
                name: "IX_postTags_TagId",
                table: "postTags",
                newName: "IX_postTags_tagId");

            migrationBuilder.RenameColumn(
                name: "Context",
                table: "posts",
                newName: "context");

            migrationBuilder.RenameColumn(
                name: "BlogId",
                table: "posts",
                newName: "blogId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "posts",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_posts_BlogId",
                table: "posts",
                newName: "IX_posts_blogId");

            migrationBuilder.RenameColumn(
                name: "BlogId",
                table: "ownerships",
                newName: "blogId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "ownerships",
                newName: "userId");

            migrationBuilder.RenameIndex(
                name: "IX_ownerships_BlogId",
                table: "ownerships",
                newName: "IX_ownerships_blogId");

            migrationBuilder.RenameColumn(
                name: "PostId",
                table: "likes",
                newName: "postId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "likes",
                newName: "userId");

            migrationBuilder.RenameIndex(
                name: "IX_likes_PostId",
                table: "likes",
                newName: "IX_likes_postId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "blogs",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "blogs",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "blogs",
                newName: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_likes_posts_postId",
                table: "likes",
                column: "postId",
                principalTable: "posts",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_likes_UserEntity_userId",
                table: "likes",
                column: "userId",
                principalTable: "UserEntity",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ownerships_blogs_blogId",
                table: "ownerships",
                column: "blogId",
                principalTable: "blogs",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ownerships_UserEntity_userId",
                table: "ownerships",
                column: "userId",
                principalTable: "UserEntity",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_posts_blogs_blogId",
                table: "posts",
                column: "blogId",
                principalTable: "blogs",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_postTags_posts_postId",
                table: "postTags",
                column: "postId",
                principalTable: "posts",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_postTags_tags_tagId",
                table: "postTags",
                column: "tagId",
                principalTable: "tags",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_subscriptions_blogs_blogId",
                table: "subscriptions",
                column: "blogId",
                principalTable: "blogs",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_subscriptions_UserEntity_userId",
                table: "subscriptions",
                column: "userId",
                principalTable: "UserEntity",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
